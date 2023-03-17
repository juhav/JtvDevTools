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
    public HttpRequestViewModel ViewModel { get; set; }

    public event Action? OnRequestChanged;

    public HttpRequestUserControl()
    {
        InitializeComponent();

        MethodComboBox.SelectedIndex = 0;
        AuthenticationComboBox.SelectedIndex = 0;
        
        ViewModel = new HttpRequestViewModel();
    }

    public void SetEditMode(HttpRequestViewModel viewModel)
    {
        ViewModel = viewModel;

        dgvHeaders.DataSource = ViewModel.Headers;
        dgvQueryParams.DataSource = ViewModel.QueryParameters;
    }

    public void SetNewMode()
    {
        ViewModel = new HttpRequestViewModel();

        dgvHeaders.DataSource = ViewModel.Headers;
        dgvQueryParams.DataSource = ViewModel.QueryParameters;
    }

    public HttpRequestViewModel GetViewModel()
    {
        ViewModel.Name = (txtRequestName.Text ?? "").Trim();
        ViewModel.ApiName = (txtApiName.Text ?? "").Trim();
        ViewModel.Method = (Models.HttpMethod)MethodComboBox.SelectedIndex;
        ViewModel.BaseURL = new string[] { BaseUrlComboBox.Text };
        ViewModel.Resource = (ResourceTextBox.Text ?? "").Trim().TrimStart('/');
        ViewModel.Authentication = (AuthenticationType)AuthenticationComboBox.SelectedIndex;
        ViewModel.ClientCertificate = ClientCertificateTextBox.Text;
        ViewModel.Body = RequestBodyTextBox.Text;

        return ViewModel;
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

