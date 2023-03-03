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
    public static ApiViewModel Map(Api src)
    {
        var result = new ApiViewModel()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };

        return result;
    }

    public static Api Map(ApiViewModel src)
    {
        var result = new Api()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };

        return result;
    }

    public static HttpRequest Map(HttpRequestViewModel src)
    {
        throw new NotImplementedException();
    }

    public static HttpRequestViewModel Map(HttpRequest src, Dictionary<Guid, Api> apiDict)
    {
        var result = new HttpRequestViewModel()
        {
            ApiName = apiDict[src.ApiId].Name
        };

        return result;
    }

    public static Variable Map(VariableViewModel viewModel)
    {
        var result = new Variable()
        {
            Id = Guid.NewGuid(),
            ApiId = Guid.Empty,
            Name = viewModel.Name,
            Value = viewModel.Name
        };

        return result;
    }

    public static VariableViewModel Map(Variable x)
    {
        var result = new VariableViewModel()
        {

        };

        return result;
    }
}
