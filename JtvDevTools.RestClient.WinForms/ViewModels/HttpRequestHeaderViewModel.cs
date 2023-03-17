namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class HttpRequestHeaderViewModel
{
    private string name = "";
    private string value = "";

    public string? Name 
    { 
        get => name; 
        set => name = (value ?? "").Trim(); 
    }
    
    public string? Value 
    {
        get => value;
        set => this.value = (value ?? "").Trim();
    }
}
