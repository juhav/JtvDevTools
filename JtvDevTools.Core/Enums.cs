using System.Text.Json.Serialization;

namespace JtvDevTools.Core;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HttpMethod
{
    Undefined = 0,
    GET,
    POST,
    PUT,
    DELETE,
    PATCH,
    HEAD,
    TRACE,
    CONNECT,
    OPTIONS
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RequestOutputMode
{
    All = 0,
    Body = 1,
    Headers = 2,
    StatusCode = 3
}
