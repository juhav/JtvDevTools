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
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: JtvDevTools.RestConsole <variables-file> <request-file>");
                return;
            }

            var variablesFile = args[0];
            var requestFile = args[1];

            if (!File.Exists(variablesFile))
            {
                Console.WriteLine($"Variables file not found '{variablesFile}'!");
                return;
            }

            if (!File.Exists(requestFile))
            {
                Console.WriteLine($"Request file not found '{requestFile}'!");
                return;
            }

            var variablesText = File.ReadAllText(variablesFile, Encoding.UTF8);
            var variables = Utils.GetKeyValuePairs(variablesText);
            var http = new HttpService();
            var parser = new Parser(variables);
            var requestText = File.ReadAllText(requestFile);

            parser.Parse(requestText);

            var operation = parser.Operation;
            var stopWatch = Stopwatch.StartNew();
            var response = http.Send(operation);
            stopWatch.Stop();
            
            Console.Write(operation.Method.ToString().ToUpper());
            Console.Write(" ");
            Console.Write(operation.BaseUrl?.TrimEnd('/'));
            Console.Write("/");
            Console.WriteLine(operation.Resource);

            PrintResponse(operation, response, stopWatch.ElapsedMilliseconds);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void PrintResponse(ApiOperation operation, RestSharp.RestResponse? response, long elapsedMilliseconds)
    {
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

        Console.Write((int)response.StatusCode);
        Console.Write(" - ");
        Console.WriteLine(response.StatusCode.ToString());

        Console.Write(elapsedMilliseconds);
        Console.WriteLine(" ms");
        Console.WriteLine();

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
            Console.WriteLine(response?.ErrorMessage);
            return;
        }

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

}
