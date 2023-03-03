namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class ApiViewModel
{
    private string name = "";
    private string description = "";

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

    public ApiViewModel()
    {
        Id = Guid.NewGuid();
    }
}
