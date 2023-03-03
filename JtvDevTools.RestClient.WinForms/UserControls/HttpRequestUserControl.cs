using JtvDevTools.RestClient.WinForms.Models;
using JtvDevTools.RestClient.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.WinForms.UserControls;

public partial class HttpRequestUserControl : UserControl
{
    public event Action OnRequestChanged;

    public HttpRequestUserControl()
    {
        InitializeComponent();

        cboApi.DisplayMember = "Name";
        cboApi.ValueMember = "Id";
        MethodComboBox.SelectedIndex = 0;
        AuthenticationComboBox.SelectedIndex = 0;
    }

    public HttpRequestViewModel GetViewModel()
    {
        var apiViewModel = (cboApi.SelectedItem as ApiViewModel);
        
        var result = new HttpRequestViewModel()
        {
            Name = (NameTextBox.Text ?? "").Trim(),
            ApiId = apiViewModel != null ? apiViewModel.Id : Guid.Empty,
            Method = (Models.HttpMethod)MethodComboBox.SelectedIndex,
            BaseURL = BaseUrlComboBox.Text,
            Resource = (ResourceTextBox.Text ?? "").Trim().TrimStart('/'),
            Authentication = (AuthenticationType)AuthenticationComboBox.SelectedIndex,
            ClientCertificate = ClientCertificateTextBox.Text,
            Headers = new List<HttpRequestHeaderViewModel>(),
            QueryParameters = new List<HttpRequestQueryParameterViewModel>()
        };

        var headers = HeadersTextBox.Lines;
        foreach (var header in headers)
        {
            if (string.IsNullOrWhiteSpace(header)) continue;
            
            if (header.Contains(':'))
            {
                var fields = header.Split(':', 2);
                var name = fields[0].Trim();
                var value = fields[1].Trim();

                if (string.IsNullOrWhiteSpace(name)) continue;

                result.Headers.Add(new HttpRequestHeaderViewModel() { Name = name, Value = value });
            }
        }

        var queryParameters = QueryParamsTextBox.Lines;
        foreach (var queryParameter in queryParameters)
        {
            if (string.IsNullOrWhiteSpace(queryParameter)) continue;

            if (queryParameter.Contains('='))
            {
                var fields = queryParameter.Split('=', 2);
                var name = fields[0].Trim();
                var value = fields[1].Trim();

                if (string.IsNullOrWhiteSpace(name)) continue;

                result.QueryParameters.Add(new HttpRequestQueryParameterViewModel() { Name = name, Value = value });
            }
        }

        return result;
    }

    private void SelectClientCertButton_Click(object sender, EventArgs e)
    {
        using (var form = new Certificates())
        {
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                ClientCertificateTextBox.Text = form.SelectedCertificate?.Thumbprint;
            }
        }
    }

    private void cboApi_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnRequestChanged?.Invoke();
    }

    private void BaseUrlComboBox_TextChanged(object sender, EventArgs e)
    {
        OnRequestChanged?.Invoke();
    }
}

