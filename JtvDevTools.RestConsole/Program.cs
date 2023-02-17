using System.Diagnostics;
using System.Text;

namespace JtvDevTools.RestConsole;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Clear();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var fileName = Path.Combine(path, "data\\variables.txt");
            var variablesText = File.ReadAllText(fileName, Encoding.UTF8);
            var variables = Utils.GetKeyValuePairs(variablesText);

            if (File.Exists(args[0]))
            {
                var http = new HttpService();
                var parser = new Models.Parser(variables);
                var requestText = File.ReadAllText(args[0]);

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