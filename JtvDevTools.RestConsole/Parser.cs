using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestConsole;

public class Parser
{
    private readonly Dictionary<string, string> variables = new Dictionary<string, string>();

    public enum MessageSection
    {
        Undefined = 0,
        Variables,
        Query,
        Headers,
        Body
    }

    public ApiOperation Operation { get; private set; }

    public Parser(Dictionary<string, string> variables)
    {
        this.variables = variables;
        Operation = new ApiOperation();
    }

    public void Parse(string instructions)
    {
        string[] lines = instructions.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        var body = new StringBuilder(4096);

        MessageSection currentSection = MessageSection.Undefined;

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();

            if (lines[i].StartsWith("#")) continue;

            if (lines[i].StartsWith("[") && lines[i].EndsWith("]"))
            {
                switch (lines[i].ToUpperInvariant())
                {
                    case "[REQUEST]":
                        currentSection = MessageSection.Variables;
                        break;

                    case "[QUERY]":
                        currentSection = MessageSection.Query;
                        break;

                    case "[HEADERS]":
                        currentSection = MessageSection.Headers;
                        break;

                    case "[BODY]":
                        currentSection = MessageSection.Body;
                        break;

                    default:
                        throw new ApplicationException($"Unknown section in request: {lines[i]}.");
                }
            }
            else
            {
                switch (currentSection)
                {
                    case MessageSection.Variables:
                        ProcessVariable(lines[i]);
                        break;

                    case MessageSection.Query:
                        ProcessQueryParam(lines[i]);
                        break;

                    case MessageSection.Headers:
                        ProcessHeader(lines[i]);
                        break;

                    case MessageSection.Body:
                        body.AppendLine(lines[i]);
                        break;
                }
            }
        }

        Operation.Body = EvaluateBody(body);
    }

    private string EvaluateBody(StringBuilder body)
    {
        var matches = System.Text.RegularExpressions.Regex.Matches(body.ToString(), @"\<\=.+?\>");

        foreach (System.Text.RegularExpressions.Match match in matches)
        {
            var value = match.Value.Trim("<=> ".ToCharArray());
            var tokens = value.Split("()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0].ToUpperInvariant())
            {
                case "FILETOBASE64":
                    var filename = tokens[1].Trim('\"');

                    if (File.Exists(filename))
                    {
                        body = body.Replace(match.Value, Utils.FileToBase64(filename));
                    }
                    else
                    {
                        throw new ApplicationException($"File not found: {filename}");
                    }
                    break;
            }

        }
        // <= fileToBase64("c:\temp\test.txt")>
        // <= guid()>
        // <= guid("N")>
        // <= randomInt(1,10)>
        // <= randomLine("c:\temp\test.txt")>

        return body.ToString();
    }

    private void ProcessHeader(string s)
    {
        Utils.GetKeyValuePair(s, out string key, out string value);
        value = GetGlobalVariable(value);

        if (!string.IsNullOrWhiteSpace(key))
        {
            Operation.Headers.Add(key, value);
        }
    }

    private void ProcessQueryParam(string s)
    {
        Utils.GetKeyValuePair(s, out string key, out string value);
        value = GetGlobalVariable(value);

        if (!string.IsNullOrWhiteSpace(key))
        {
            Operation.QueryParams.Add(key, value);
        }
    }

    private void ProcessVariable(string s)
    {
        Utils.GetKeyValuePair(s, out string key, out string value);

        if (!string.IsNullOrWhiteSpace(key))
        {
            SetVariable(key, value);
        }
    }

    private string GetGlobalVariable(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return value;

        if (value.StartsWith('<') && value.EndsWith('>'))
        {
            value = value.Trim("<>".ToCharArray());

            if (variables.TryGetValue(value, out string? variable))
            {
                value = variable;
            }
            else
            {
                throw new ApplicationException($"Variable '{value}' not found.");
            }
        }

        return value;
    }

    private void SetVariable(string key, string value)
    {
        value = GetGlobalVariable(value);

        switch (key.ToUpperInvariant())
        {
            case "METHOD":
                Operation.Method = HttpMethod.GET;
                if (Enum.TryParse(value, true, out HttpMethod method))
                {
                    Operation.Method = method;
                }
                break;

            case "RESOURCE":
                Operation.Resource = value;
                break;

            case "BASEURL":
                Operation.BaseUrl = value;
                break;

            case "USER":
                Operation.User = value;
                break;

            case "PWD":
                Operation.Pwd = value;
                break;

            case "CLIENTCERT":
            case "CLIENT CERT":
                Operation.ClientCertificate = value.Replace(" ", "");
                break;

            case "AUTH":
                Operation.AuthenticatorName = value;
                break;

            case "PRETTYPRINT":
            case "PRETTY PRINT":
                Operation.PrettyPrint = value.ToLowerInvariant() == "true";
                break;

            //case "DEFAULTCREDENTIALS":
            //case "DEFAULT CREDENTIALS":
            //    Operation.UseDefaultCredentials = value.ToLowerInvariant() == "true"; ;
            //    break;

            case "NAME":
                break;

            default:
                throw new ApplicationException($"Unknown variable: {key}.");
        }
    }



}
