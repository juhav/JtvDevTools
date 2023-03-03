namespace JtvDevTools.Core;

public class CertificateViewModel
{
    public CertificateViewModel()
    {
    }

    public string? FriendlyName { get; set; }
    public string? Name { get; set; }
    public DateTime NotAfter { get; set; }
    public DateTime NotBefore { get; set; }
    public string? Subject { get; set; }
    public string? Thumbprint { get; set; }
}