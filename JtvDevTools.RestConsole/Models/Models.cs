using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JtvDevTools.RestConsole.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HttpMethod
{
    GET = 0,
    POST,
    PUT,
    DELETE
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AuthType
{
    NONE = 0,
    NTLM,
    BASIC
}


public class ApiOperation
{
    private string authenticatorName = "";

    public int Id { get; set; }
    public string? BaseUrl { get; set; }
    public string? Name { get; set; }
    public string? ApiName { get; set; }
    public HttpMethod Method { get; set; }
    public string? Resource { get; set; }
    public string? Body { get; set; }
    public Dictionary<string, string> Headers { get; }
    public Dictionary<string, string> QueryParams { get; }
    
    public string AuthenticatorName 
    {
        get => authenticatorName;
        set => authenticatorName = (value ?? "").Trim().ToUpperInvariant();
    }
    
    public string? User { get; set; }
    public string? Pwd { get; set; }
    public string? ClientCertificate { get; set; }
    public bool PrettyPrint { get; set; }
    public bool UseDefaultCredentials { get; internal set; }

    public ApiOperation()
    {
        Headers = new Dictionary<string, string>();
        QueryParams = new Dictionary<string, string>();
    }
}


//public class ApiConfiguration
//{
//    private List<Api> apis = new List<Api>();

//    public List<Api> Apis 
//    {
//        get => apis;
//        set => apis = value ?? new List<Api>();
//    }

//    public ApiConfiguration()
//    {
        
//    }

//    public static ApiConfiguration? LoadFromJson(string fileName)
//    {
//        var json = File.ReadAllText(fileName, Encoding.UTF8);
//        var result = System.Text.Json.JsonSerializer.Deserialize<ApiConfiguration>(json);
        
//        return result;
//    }

//    public static string? Validate(ApiConfiguration? config)
//    {
//        if (config == null) return "Invalid config.";
//        if (config.Apis == null) return "No APIs defined.";

//        var apiHashSet = new HashSet<int>();
//        foreach  (var api in config.Apis)
//        {
//            if (apiHashSet.Contains(api.Id)) return $"Duplicate API Id: {api.Id}";
            
//            apiHashSet.Add(api.Id);
          
//        }

//        return null;
//    }


//}