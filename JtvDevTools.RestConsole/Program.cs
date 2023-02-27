using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace JtvDevTools.RestConsole;

public class RestConsoleConfig
{
    public string? LibraryFolder { get; set; }    

    public string? VariablesFile { get; set; }  
}

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length == 0)
            {
                Console.WriteLine("API operation file is missing.");
                return;
            }

            Console.Clear();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var jsonConfigFile = Path.Combine(path, "JtvDevTools.RestConsole.json");

            var json = File.ReadAllText(jsonConfigFile, Encoding.UTF8);
            var config = System.Text.Json.JsonSerializer.Deserialize<RestConsoleConfig>(json);

            if (config == null)
            {
                Console.WriteLine("JtvDevTools.RestConsole.json is invalid!");
                return;
            }

            if (!Directory.Exists(config.LibraryFolder))
            {
                Console.WriteLine($"Folder not found '{config.LibraryFolder}'!");
                return;
            }

            var fileName = Path.Combine(config.LibraryFolder, config.VariablesFile ?? "");

            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File not found '{config.LibraryFolder}'!");
                return;
            }

            var variablesText = File.ReadAllText(fileName, Encoding.UTF8);
            var variables = Utils.GetKeyValuePairs(variablesText);
            var operationFile = Path.Combine(config.LibraryFolder, args[0]);

            if (File.Exists(operationFile))
            {
                var http = new HttpService();
                var parser = new Models.Parser(variables);
                var requestText = File.ReadAllText(operationFile);

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

                Console.Write((int)response.StatusCode);
                Console.Write(" - ");
                Console.WriteLine(response.StatusCode.ToString());

                Console.Write(stopWatch.ElapsedMilliseconds);
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

                var contentType = (response.ContentType ?? "");

                if (response.IsSuccessful)
                {
                    if (operation.PrettyPrint && contentType.Contains("application/json")
                        || contentType.Contains("application/problem+json"))
                    {
                        Console.WriteLine(Utils.PrettyJson(response.Content));
                    }
                    else if (operation.PrettyPrint && contentType.Contains("text/xml")
                        || contentType.Contains("application/xml"))
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
                    Console.WriteLine(response.ErrorMessage);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
   
    
}
