using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms.Models;

public enum HttpMethod
{
    GET = 0,
    POST = 1,
    PUT = 2,
    DELETE = 3,
    PATCH = 4,
    HEAD = 5,
    CONNECT = 6,
    OPTIONS = 7,
    TRACE = 8
}

public enum AuthenticationType
{
    None = 0,
    Basic = 1,
    WindowsWithDefaultCredentials = 2,
    Windows = 3
}

public interface IModel
{
    Guid Id { get; set; }
}

public class HttpRequestHeader
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class HttpRequestQueryParameter
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class HttpRequest : IModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ApiName { get; set; }
    public HttpMethod Method { get; set; }
    public string[]? BaseURL { get; set; }
    public string? Resource { get; set; }
    public AuthenticationType Authentication { get; set; }
    public string? ClientCertificate { get; set; }
    public string? Body { get; set; }
    public List<HttpRequestHeader>? Headers { get; set; }
    public List<HttpRequestQueryParameter>? QueryParameters { get; set; }
}

public class Certificate
{
    public string? Subject { get; set; }
    public string? FriendlyName { get; set; }
    public string? Name { get; set; }
    public DateTime NotAfter { get; set; }
    public DateTime NotBefore { get; set; }
    public string? Thumbprint { get; set; }

    public Certificate()
    {
    }
}

public class Variable : IModel
{
    public Guid Id { get; set; }
    public Guid ApiId { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
}