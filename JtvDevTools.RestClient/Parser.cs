using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient
{
    public class Parser
    {
        private readonly Dictionary<string, string> variables;
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
            this.variables = variables;

            evaluator = new CodingSeb.ExpressionEvaluator.ExpressionEvaluator()
            {
                Context = new EvaluatorContext()
                {
                    Variables = variables
                },
                OptionCaseSensitiveEvaluationActive = false
            };

            ApiRequest = new ApiRequest();
        }

        public void Parse(string requestText, string body, bool evaluate = true)
        {
            if (string.IsNullOrWhiteSpace(requestText)) return;

            if (evaluate)
            {
                requestText = EvaluateExpressions(requestText);
                ApiRequest.Body = EvaluateExpressions(body).Trim();
            }

            string[] lines = requestText.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

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

        private string EvaluateExpressions(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            var matches = System.Text.RegularExpressions.Regex.Matches(text, @"\%.+?\%");

            if (matches.Count == 0) return text;

            var sb = new StringBuilder(4096);
            sb.Append(text);

            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                string value = match.Value.Trim("% ".ToCharArray());
                string result;

                if (variables.ContainsKey(value))
                {
                    result = variables[value];
                }

                else
                {
                    result = (string)evaluator.Evaluate(value);
                }

                sb = sb.Replace(match.Value, result);
            }

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
                case "API":
                    ApiRequest.ApiName = value;
                    break;

                case "METHOD":
                    ApiRequest.Method = ParseHttpMethod(value);
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

                case "CLIENTCERTIFICATE":
                case "CLIENTCERT":
                case "CLIENT CERT":
                    ApiRequest.ClientCertificate = value.Replace(" ", "");
                    break;

                case "AUTH":
                    ApiRequest.Authenticator = ParseAuthenticatorType(value);
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
                    ApiRequest.Name = value;
                    break;

                case "SAVERESPONSEBODYTOFILE":
                    ApiRequest.SaveResponseBodyToFile = value;
                    break;

                case "PREAUTHENTICATE":
                    ApiRequest.PreAuthenticate = value.ToLowerInvariant() == "true";
                    break;

                case "EXPECTEDSTATUSCODE":
                    ApiRequest.ExpectedStatusCode = 200;
                    break;

                default:
                    throw new ApplicationException($"Unknown variable: {key}.");
            }
        }

        private HttpMethod ParseHttpMethod(string value)
        {
            if (Enum.TryParse(value, true, out HttpMethod method))
            {
                return method;
            }

            return HttpMethod.Undefined;
        }

        private AuthenticatorType ParseAuthenticatorType(string value)
        {
            if (Enum.TryParse(value, true, out AuthenticatorType authType))
            {
                return authType;
            }

            return AuthenticatorType.None;
        }
    }
}