using System.ComponentModel;

namespace JtvDevTools.RestClient.WinForms.ViewModels;


public class ScopeViewModel
{
    public string Name { get; set; }
}

public class ApiViewModel
{
    private string name = "";
    private string description = "";
    private BindingList<ScopeViewModel> scopes = new BindingList<ScopeViewModel>();

    public Guid Id 
    { 
        get; 
        set; 
    }

    public string Name
    {
        get => name;
        set => name = (value ?? "").Trim();
    }

    public string Description
    {
        get => description;
        set => description = (value ?? "").Trim();
    }

    public BindingList<ScopeViewModel> Scopes
    {
        get => scopes;
        set => scopes = value;
    }

    public ApiViewModel()
    {
        Id = Guid.NewGuid();
    }
}
