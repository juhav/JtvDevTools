using JtvDevTools.RestClient.WinForms.Models;
using HttpMethod = JtvDevTools.RestClient.WinForms.Models.HttpMethod;

namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class HttpRequestViewModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid ApiId { get; set; }
    public string? ApiName { get; set; }
    public HttpMethod Method { get; set; }
    public string? BaseURL { get; set; }
    public string? Resource { get; set; }
    public AuthenticationType Authentication { get; set; }
    public string? ClientCertificate { get; set; }
    public List<HttpRequestHeaderViewModel>? Headers { get; set; }
    public List<HttpRequestQueryParameterViewModel>? QueryParameters { get; set; }

    public HttpRequestViewModel()
    {
        Id = Guid.NewGuid();
    }

    public bool IsValid()
    {
        if (ApiId == Guid.Empty) return false;
        if (string.IsNullOrWhiteSpace(BaseURL)) return false;

        return true;
    }
}

public class HttpRequestHeaderViewModel
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class HttpRequestQueryParameterViewModel
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}
