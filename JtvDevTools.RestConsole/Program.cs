using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace JtvDevTools.RestConsole;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: JtvDevTools.RestConsole <request.txt>");
                return;
            }

            var requestFile = args[0];
            var variablesFile = Path.Combine(Path.GetDirectoryName(requestFile)!, "variables.txt");

            if (!File.Exists(requestFile))
            {
                Console.WriteLine($"Request file not found '{requestFile}'!");
                return;
            }

            Dictionary<string, string> variables;
            if (File.Exists(variablesFile))
            {
                var variablesText = File.ReadAllText(variablesFile, Encoding.UTF8);
                variables = Utils.GetKeyValuePairs(variablesText);
            }
            else
            {
                variables = new Dictionary<string, string>();
            }

            var parser = new Parser(variables);
            var requestText = File.ReadAllText(requestFile, Encoding.UTF8);

            parser.Parse(requestText);
            var request = parser.ApiRequest;

            if (request == null)
            {
                Console.WriteLine($"Request is null after parsing!");
                return;
            }

            Evaluate(request);

            var http = new HttpService();

            var fgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(request.Method.ToString().ToUpper());
            Console.Write(" ");
            Console.Write(request.BaseUrl);
            Console.Write("/");
            Console.WriteLine(request.Resource);
            Console.ForegroundColor = fgColor;

            var stopWatch = Stopwatch.StartNew();
            var response = http.Send(request);
            stopWatch.Stop();

            PrintResponse(request, response, stopWatch.ElapsedMilliseconds);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void PrintResponse(ApiRequest operation, RestSharp.RestResponse? response, long elapsedMilliseconds)
    {
        var fgColor = Console.ForegroundColor;

        if (operation == null)
        {
            Console.WriteLine("API operation is null.");
            return;
        }

        if (response == null)
        {
            Console.WriteLine("Response is null.");
            return;
        }

        if (response.IsSuccessStatusCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.Write((int)response.StatusCode);
        Console.Write(" - ");
        Console.WriteLine(response.StatusCode.ToString());

        Console.ForegroundColor = fgColor;
        Console.Write(elapsedMilliseconds);
        Console.WriteLine(" ms");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        if (response.Headers != null)
        {
            foreach (var header in response.Headers)
            {
                Console.Write(header.Name);
                Console.Write(": ");
                Console.WriteLine(header.Value?.ToString());
            }
        }

        Console.WriteLine();

        if (!response.IsSuccessful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(response?.ErrorMessage);
            Console.ForegroundColor = fgColor; 
            return;
        }

        Console.ForegroundColor = fgColor;

        var contentType = (response.ContentType ?? "");

        if (operation.PrettyPrint)
        {
            if (contentType.Contains("application/json") || contentType.Contains("application/problem+json"))
            {
                Console.WriteLine(Utils.PrettyJson(response.Content));
            }
            else if (contentType.Contains("text/xml") || contentType.Contains("application/xml"))
            {
                Console.WriteLine(Utils.PrettyXML(response.Content));
            }
            else
            {
                Console.WriteLine(response.Content);
            }
        }
        else
        {
            Console.WriteLine(response.Content);
        }
    }

    private static void Evaluate(ApiRequest request)
    {
        var sb = new StringBuilder(32768);

        var eval = new CodingSeb.ExpressionEvaluator.ExpressionEvaluator();
        
        eval.Context = new EvaluatorContext();

        request.BaseUrl = Evaluate(request.BaseUrl, sb, eval);
        request.Resource = Evaluate(request.Resource, sb, eval);
        request.Body = Evaluate(request.Body, sb, eval);
        request.User = Evaluate(request.User, sb, eval);
        request.Pwd = Evaluate(request.Pwd, sb, eval);
        request.ClientCertificate = Evaluate(request.ClientCertificate, sb, eval);
    }

    private static string Evaluate(string? text, StringBuilder sb, CodingSeb.ExpressionEvaluator.ExpressionEvaluator evaluator)
    {
        if (string.IsNullOrWhiteSpace(text)) return "";

        sb.Clear();

        var matches = System.Text.RegularExpressions.Regex.Matches(text, @"\<\=.+?\>");

        if (matches.Count == 0) return text;

        sb.Append(text);

        foreach (System.Text.RegularExpressions.Match match in matches)
        {
            var value = match.Value.Trim("<=> ".ToCharArray());
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

    public static string GetApiRequestAsJson()
    {
        var request = new ApiRequest()
        {
            AuthenticatorName = "NTLM",
            Body = "",
            ClientCertificate = "",
            Method = HttpMethod.GET,
            Name = "Sample request",
            Resource = "api/v1/sample",
            
        };
        request.Headers.Add("Cache-Control", "no-cache");

        var result = System.Text.Json.JsonSerializer.Serialize(request, new System.Text.Json.JsonSerializerOptions()
        {
            WriteIndented = true
        });

        return result;
    }

    public static ApiRequest? GetApiRequestFromJson(string json)
    {
        var request = new ApiRequest()
        {
            AuthenticatorName = "NTLM",
            Body = "",
            ClientCertificate = "",
            Method = HttpMethod.GET,
            Name = "Sample request",
            Resource = "api/v1/sample",
        };

        var result = System.Text.Json.JsonSerializer.Deserialize<ApiRequest>(json, new System.Text.Json.JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = false,
            WriteIndented = true
        });

        return result;
    }
}
