using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Text;

namespace JtvDevTools.RestConsole;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: JtvDevTools.RestConsole <request.txt> <variables.txt> mode");
                return;
            }

            var requestFile = args[0];
            var variablesFile = args[1];
            var outputMode = RequestOutputMode.All;

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

            if (args.Length > 2)
            {
                outputMode = Enum.Parse<RequestOutputMode>(args[2], true);
            }

            var parser = new Parser(variables);
            var requestText = File.ReadAllText(requestFile, Encoding.UTF8);

            parser.Parse(requestText);
            var request = parser.ApiRequest;
            request.OutputMode = outputMode;

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
            Console.Write(request.Resource);
            Console.Write(" ");
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

        if (operation.OutputMode == RequestOutputMode.All || operation.OutputMode == RequestOutputMode.StatusCode)
        {
            Console.Write("[");

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
            Console.Write(response.StatusCode.ToString());

            Console.ForegroundColor = fgColor;
            Console.Write("] ");

            Console.Write($"{elapsedMilliseconds} ms");
            //Console.WriteLine($"Content Type: {contentType}");
            Console.WriteLine($", {contentLength} bytes");
        }

        //if (operation.OutputMode == RequestOutputMode.All)
        //{
        //    Console.ForegroundColor = fgColor;
        //    Console.WriteLine($"Elapsed Time: {elapsedMilliseconds} ms");
        //    Console.WriteLine($"Content Type: {contentType}");
        //    Console.WriteLine($"Content Length: {contentLength} bytes");
        //    Console.WriteLine();
        //}

        PrintHeaders(operation, response);

        if (!response.IsSuccessful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(response?.ErrorMessage);
            Console.ForegroundColor = fgColor;
            return;
        }

        Console.ForegroundColor = fgColor;


        bool isOutputFile = !string.IsNullOrWhiteSpace(operation.SaveResponseBodyToFile);
        bool isOutputModeWithBody = operation.OutputMode == RequestOutputMode.All || operation.OutputMode == RequestOutputMode.Body;

        if (isOutputFile || isOutputModeWithBody)
        {
            if (operation.PrettyPrint)
            {
                if (contentType.Contains("application/json") || contentType.Contains("application/problem+json"))
                {
                    var json = Utils.PrettyJson(response.Content);

                    if (isOutputModeWithBody)
                    {
                        Console.WriteLine(json);
                    }

                    if (isOutputFile)
                    {
                        File.WriteAllText(operation.SaveResponseBodyToFile, json, Encoding.UTF8);
                    }
                }
                else if (contentType.Contains("text/xml") || contentType.Contains("application/xml"))
                {
                    var xml = Utils.PrettyXML(response.Content);

                    if (isOutputModeWithBody)
                    {
                        Console.WriteLine(xml);
                    }

                    if (isOutputFile)
                    {
                        File.WriteAllText(operation.SaveResponseBodyToFile, xml, Encoding.UTF8);
                    }
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

    private static void PrintHeaders(ApiRequest operation, RestResponse response)
    {
        if (!(operation.OutputMode == RequestOutputMode.All || operation.OutputMode == RequestOutputMode.Headers)) return;
        if (response.Headers == null) return;

        Console.ForegroundColor = ConsoleColor.DarkGray;

        foreach (var header in response.Headers)
        {
            Console.Write(header.Name);
            Console.Write(": ");
            Console.WriteLine(header.Value?.ToString());
        }

        Console.WriteLine();
    }


}
