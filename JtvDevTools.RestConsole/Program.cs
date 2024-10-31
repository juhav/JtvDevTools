using JtvDevTools.Core;
using JtvDevTools.RestConsole;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Text;
using HttpMethod = JtvDevTools.Core.HttpMethod;

namespace JtvDevTools.RestConsole;

internal class Program
{
    private static void PrintHelp()
    {
        Console.WriteLine("Usage: JtvDevTools.RestConsole new|test|send");
        Console.WriteLine("# new");
        Console.WriteLine("  Prints empty request template to console.");
        Console.WriteLine("");
        Console.WriteLine("# send <request file> <variables file> <output mode>");
        Console.WriteLine("  Sends the http request from the given request file.");
        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        //var cert = Utils.GetCertificateFromStore(System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine, "thumbprint");

        //var en = Utils.Encrypt(cert, "pwd_is_test");
        //var de = Utils.Decrypt(cert, en);

        try
        {
            if (args.Length == 0)
            {
                PrintHelp();
                return;
            }

            if (args[0] == "new")
            {
                PrintRequestTemplate(args);
                return;
            }

            if (args[0] == "send")
            {
                SendRequest(args);
                return;
            }

            PrintHelp();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void PrintResponse(ApiRequest operation, RestSharp.RestResponse? response, long elapsedMilliseconds)
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

            Console.ResetColor();
            Console.Write("] ");

            Console.Write($"{elapsedMilliseconds} ms");
            Console.WriteLine($", {contentLength} bytes");
        }

        if (!response.IsSuccessful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(response?.ErrorMessage);
        }

        PrintHeaders(operation, response);

        Console.ResetColor();

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

    private static void PrintRequestTemplate(string[] args)
    {
        var request = new ApiRequest()
        {
            BaseUrl = "https://api",
            Method = HttpMethod.GET,
            Resource = "v1/api/",
            Name = "Get request",
            PrettyPrint = true
        };

        Console.WriteLine(request.ToString());
    }

    private static void SendRequest(string[] args)
    {
        var requestFile = args[1];
        var variablesFile = args[2];
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

        if (args.Length > 3)
        {
            outputMode = Enum.Parse<RequestOutputMode>(args[3], true);
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

}
