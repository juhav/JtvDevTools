using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestConsole;

public class Parser
{
    private readonly CodingSeb.ExpressionEvaluator.ExpressionEvaluator evaluator;

    public enum MessageSection
    {
        Undefined = 0,
        Variables,
        Query,
        Headers,
        Body
    }

    public ApiRequest ApiRequest { get; private set; }

    public Parser(Dictionary<string, string> variables)
    {
        evaluator = new CodingSeb.ExpressionEvaluator.ExpressionEvaluator()
        {
            Context = new EvaluatorContext()
            {
                Variables = variables
            }
        };

        ApiRequest = new ApiRequest();
    }

    public void Parse(string requestText)
    {
        if (string.IsNullOrWhiteSpace(requestText)) return;

        var bodyIndex = requestText.IndexOf("[BODY]", StringComparison.InvariantCultureIgnoreCase);

        if (bodyIndex == -1) return;
       
        var requestVariablesText = requestText.Substring(0, bodyIndex);
        var bodyText = requestText.Substring(bodyIndex + 6);

        requestVariablesText = Evaluate(requestVariablesText);
        ApiRequest.Body = Evaluate(bodyText).Trim();

        string[] lines = requestVariablesText.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

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
                         break;
                }
            }
        }

    }

    private string Evaluate(string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) return "";

        var matches = System.Text.RegularExpressions.Regex.Matches(text, @"\{\!.+?\!\}");

        if (matches.Count == 0) return text;

        var sb = new StringBuilder(4096);
        sb.Append(text);

        foreach (System.Text.RegularExpressions.Match match in matches)
        {
            var value = match.Value.Trim("{}! ".ToCharArray());
            var result = (string)evaluator.Evaluate(value);

            sb = sb.Replace(match.Value, result);
        }
        // <= fileToBase64("c:\temp\test.txt")>
        // <= guid()>
        // <= guid("N")>
        // <= randomInt(1,10)>
        // <= randomLine("c:\temp\test.txt")>
        // <= var("XAPI.TEST.BASEURL")>

        return sb.ToString();
    }

    private void ProcessHeader(string s)
    {
        Utils.GetKeyValuePair(s, out string key, out string value);

        if (!string.IsNullOrWhiteSpace(key))
        {
            ApiRequest.Headers.Add(key, value);
        }
    }

    private void ProcessQueryParam(string s)
    {
        Utils.GetKeyValuePair(s, out string key, out string value);

        if (!string.IsNullOrWhiteSpace(key))
        {
            ApiRequest.QueryParams.Add(key, value);
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

    private void SetVariable(string key, string value)
    {
        switch (key.ToUpperInvariant())
        {
            case "METHOD":
                ApiRequest.Method = HttpMethod.Undefined;
                
                if (Enum.TryParse(value, true, out HttpMethod method))
                {
                    ApiRequest.Method = method;
                }
                break;

            case "RESOURCE":
                ApiRequest.Resource = value;
                break;

            case "BASEURL":
                ApiRequest.BaseUrl = value;
                break;

            case "USER":
                ApiRequest.User = value;
                break;

            case "PWD":
                ApiRequest.Pwd = value;
                break;

            case "CLIENTCERT":
            case "CLIENT CERT":
                ApiRequest.ClientCertificate = value.Replace(" ", "");
                break;

            case "AUTH":
                ApiRequest.AuthenticatorName = value;
                break;

            case "PRETTYPRINT":
            case "PRETTY PRINT":
                ApiRequest.PrettyPrint = value.ToLowerInvariant() == "true";
                break;

            case "ID":
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ApiRequest.Id = new Guid(value);
                }
                break;

            case "NAME":
                ApiRequest.Name = value.Trim();
                break;

            default:
                throw new ApplicationException($"Unknown variable: {key}.");
        }
    }



}
