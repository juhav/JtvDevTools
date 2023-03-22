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

        var contentType = (response.ContentType ?? "");
        var contentLength = response.Content != null ? response.Content.Length : 0;

        Console.Write("HTTP Status: ");

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
        Console.WriteLine($"Elapsed Time: {elapsedMilliseconds} ms");
        Console.WriteLine($"Content Type: {contentType}");
        Console.WriteLine($"Content Length: {contentLength} bytes");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkGray;
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

    
}
