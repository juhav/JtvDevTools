using JtvDevTools.RestClient.WinForms.Models;
using JtvDevTools.RestClient.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms;

public static class Mapper
{
    public static HttpRequest Map(HttpRequestViewModel src)
    {
        var result = new HttpRequest()
        {
            ApiName = src.ApiName,
            Authentication = src.Authentication,
            BaseURL = src.BaseURL,
            Body = src.Body,
            ClientCertificate = src.ClientCertificate,
            Headers = src.Headers.Select(x => Map(x)).ToList(),
            Id = src.Id,
            Method = src.Method,
            Name = src.Name,
            QueryParameters = src.QueryParameters.Select(x => Map(x)).ToList(),
            Resource = src.Resource
        };

        return result;
    }

    public static HttpRequestViewModel Map(HttpRequest src)
    {
        var result = new HttpRequestViewModel()
        {
            
        };

        return result;
    }

    public static HttpRequestQueryParameter Map(HttpRequestQueryParameterViewModel src)
    {
        var result = new HttpRequestQueryParameter()
        {
            Name = src.Name,
            Value = src.Value,
        };

        return result;
    }

    public static HttpRequestHeader Map(HttpRequestHeaderViewModel src)
    {
        var result = new HttpRequestHeader()
        {
            Name = src.Name,
            Value = src.Value,
        };

        return result;
    }

    public static Variable Map(VariableViewModel src)
    {
        var result = new Variable()
        {
            Id = Guid.NewGuid(),
            ApiId = Guid.Empty,
            Name = src.Name,
            Value = src.Name
        };

        return result;
    }

    public static VariableViewModel Map(Variable src)
    {
        var result = new VariableViewModel()
        {
            Id = src.Id,
        };

        return result;
    }
}
