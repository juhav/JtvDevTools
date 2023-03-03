using JtvDevTools.RestClient.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms;

public class RestClientApp
{
    private readonly IDB database;

    public BindingList<ApiViewModel> ApisBindingList
    {
        get;
        private set;
    }

    public BindingList<HttpRequestViewModel> RequestsBindingList
    {
        get;
        private set;
    }

    public BindingList<VariableViewModel> VariablesBindingList
    {
        get;
        private set;

    }
    public Dictionary<Guid, Models.Api> ApiDictionary
    {
        get;
        set;
    }

    public IDB Database
    {
        get
        {
            return database;
        }
    }

    public RestClientApp(IDB database)
    {
        this.ApisBindingList = new BindingList<ApiViewModel>();
        this.RequestsBindingList = new BindingList<HttpRequestViewModel>();
        this.VariablesBindingList = new BindingList<VariableViewModel>();
        this.ApiDictionary = new Dictionary<Guid, Models.Api>();
        this.database = database;
    }

    public void LoadData()
    {
        var apis = database.GetApis();
        var requests = database.GetRequests();
        var variables = database.GetVariables();

        ApiDictionary = apis.ToDictionary(x => x.Id);
        
        ApisBindingList = new BindingList<ApiViewModel>(apis.Select(x => Mapper.Map(x)).ToList());
        RequestsBindingList = new BindingList<HttpRequestViewModel>(requests.Select(x => Mapper.Map(x, ApiDictionary)).ToList());
        VariablesBindingList = new BindingList<VariableViewModel>(variables.Select(x => Mapper.Map(x)).ToList());
    }

    public void AddApi(ApiViewModel viewModel)
    {
        if (viewModel == null) return;

        ApisBindingList.Add(viewModel);
        var model = Mapper.Map(viewModel);
        database.SaveApi(model);
    }

    public void AddRequest(HttpRequestViewModel viewModel)
    {
        if (viewModel == null) return;

        RequestsBindingList.Add(viewModel);
        var model = Mapper.Map(viewModel);
        database.SaveRequest(model);
    }

    public void AddVariable(VariableViewModel viewModel)
    {
        if (viewModel == null) return;

        VariablesBindingList.Add(viewModel);
        var model = Mapper.Map(viewModel);
        database.SaveVariable(model);
    }

    public void DeleteApi(ApiViewModel viewModel)
    {
        if (viewModel == null) return;

        ApisBindingList.Remove(viewModel);
        database.DeleteApi(viewModel.Id);
    }

    public void DeleteRequest(HttpRequestViewModel viewModel)
    {
        if (viewModel == null) return;

        RequestsBindingList.Remove(viewModel);
        database.DeleteRequest(viewModel.Id);
    }

    public void DeleteVariable(VariableViewModel viewModel)
    {
        if (viewModel == null) return;

        VariablesBindingList.Remove(viewModel);
        database.DeleteVariable(viewModel.Id);
    }
}
