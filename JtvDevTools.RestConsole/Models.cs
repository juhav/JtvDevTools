using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JtvDevTools.RestConsole;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HttpMethod
{
    GET = 0,
    POST,
    PUT,
    DELETE
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

    public ApiOperation()
    {
        Headers = new Dictionary<string, string>();
        QueryParams = new Dictionary<string, string>();
    }
}


