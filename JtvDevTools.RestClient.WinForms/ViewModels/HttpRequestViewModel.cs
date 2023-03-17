using JtvDevTools.RestClient.WinForms.Models;
using System.ComponentModel;
using HttpMethod = JtvDevTools.RestClient.WinForms.Models.HttpMethod;

namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class HttpRequestViewModel
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
    public BindingList<HttpRequestHeaderViewModel> Headers { get; set; }
    public BindingList<HttpRequestQueryParameterViewModel> QueryParameters { get; set; }

    public HttpRequestViewModel()
    {
        Id = Guid.NewGuid();
        Headers = new BindingList<HttpRequestHeaderViewModel>();
        QueryParameters = new BindingList<HttpRequestQueryParameterViewModel>();
    }

    public bool IsValid()
    {
       
        if (string.IsNullOrWhiteSpace(Name)) return false;

        return true;
    }
}
