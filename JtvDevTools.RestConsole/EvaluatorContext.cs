namespace JtvDevTools.RestConsole;

//public class RestRequestCommandLineParser
//{
//    public ApiOperation? Parse(string[] args)
//    {
//        // Method:GET BaseUrl:https://catfact.ninja/ Resource:fact Auth:NTLM ClientCert: PrettyPrint:true Header:Id=No-cache Header:X-Header=Set Query:Id=2 Body:"filename.txt"

//        var result = new ApiOperation();

//        foreach (var arg in args)
//        {
//            var fields = arg.Split(':', 2);
//            var key = fields[0].ToUpper();
//            var value = fields[1].ToUpper();

//            switch (key)
//            {
//                case "METHOD":
//                    HttpMethod method;

//                    if (!Enum.TryParse<HttpMethod>(args[0], true, out method))
//                    {
//                        Console.WriteLine($"HTTP method {args[0]} is unsupported.");
//                        return null;
//                    }

//                    result.Method = method;
//                    break;

//                case "BASEURL":
//                    result.BaseUrl = value;
//                    break;

//                case "RESOURCE":
//                    result.Resource = value;
//                    break;

//                case "HEADER":
//                    Utils.GetKeyValuePair(value, out string headerName, out string headerValue);
//                    result.Headers.Add(headerName, headerValue);
//                    break;

//                case "QUERY":
//                    Utils.GetKeyValuePair(value, out string queryParamName, out string queryParamValue);
//                    result.QueryParams.Add(queryParamName, queryParamValue);
//                    break;
//            }
//        }


//        return result;
//    }
//}

public class EvaluatorContext
{
    private Random rng = new Random();

    public Dictionary<string, string> Variables = new Dictionary<string, string>();

    public EvaluatorContext()
    {
    }

    public string? Input(string prompt)
    {
        Console.Write(prompt);
        Console.Write(" ");

        var input = Console.ReadLine();

        return input;
    }

    public string? RandomInt(int min, int max)
    {
        var number = rng.Next(min, max + 1);

        return number.ToString();
    }

    public string? FileToBase64(string fileName)
    {
        if (File.Exists(fileName))
        {
            return Utils.FileToBase64(fileName);
        }
        else
        {
            throw new ApplicationException($"File not found: {fileName}");
        }
    }

    public string NewGuid()
    {
        return Guid.NewGuid().ToString();
    }

    public string NewGuid(string format)
    {
        return Guid.NewGuid().ToString(format);
    }

    public string Var(string name)
    {
        return Variables[name];
    }

    public string RandomLine(string fileName)
    {
        if (File.Exists(fileName))
        {
            var lines = File.ReadAllLines(fileName);
            int i = rng.Next(0, lines.Length);

            return lines[i];
        }
        else
        {
            throw new ApplicationException($"File not found: {fileName}");
        }
    }
}
