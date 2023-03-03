namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class VariableViewModel
{
    private Guid id;
    private string name = "";
    private int scope;
    private string value = "";

    public Guid Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = (value ?? "").Trim();
    }

    public int Scope
    {
        get => scope;
        set => scope = value;
    }

    public string Value
    {
        get => value;
        set => this.value = (value ?? "").Trim();
    }
}