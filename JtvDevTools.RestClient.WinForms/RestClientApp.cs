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

    public IDB Database
    {
        get
        {
            return database;
        }
    }

    public RestClientApp(IDB database)
    {
        this.RequestsBindingList = new BindingList<HttpRequestViewModel>();
        this.VariablesBindingList = new BindingList<VariableViewModel>();
        this.database = database;
    }

    public void LoadData()
    {

        var requests = database.GetRequests();
        var variables = database.GetVariables();

        RequestsBindingList = new BindingList<HttpRequestViewModel>(requests.Select(x => Mapper.Map(x)).ToList());
        VariablesBindingList = new BindingList<VariableViewModel>(variables.Select(x => Mapper.Map(x)).ToList());
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
