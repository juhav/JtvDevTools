using JtvDevTools.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public partial class RequestUserControl : UserControl
    {
        public ApiRequest GetApiRequest()
        {
            var request = new ApiRequest();

            request.Id = new Guid(txtId.Text.Trim());
            request.Name = txtName.Text.Trim();
            request.ApiName = txtAPI.Text.Trim();
            request.BaseUrl = txtBaseUrl.Text.Trim();
            request.Resource = txtResource.Text.Trim();
            request.Method = HttpMethod.GET;

            if (Enum.TryParse(cboMethod.SelectedItem.ToString(), out HttpMethod method))
            {
                request.Method = method;
            }

            request.AuthenticatorName = "";
            
            if (cboAuth.SelectedItem != null)
            {
                request.AuthenticatorName = cboAuth.SelectedItem.ToString();
            }

            request.PreAuthenticate = chkPreAuthenticate.Checked;
            request.ClientCertificate = txtClientCertificate.Text.Trim();
            request.PrettyPrint = chkPrettyPrint.Checked;
            request.SaveResponseBodyToFile = txtSaveResponseBodyToFile.Text.Trim();
            request.ExpectedStatusCode = 200;

            if (int.TryParse(txtExpectStatus.Text, out int statusCode))
            {
                request.ExpectedStatusCode = statusCode;
            }

            for (int i=0; i<txtHeaders.Lines.Count; i++)
            {
                if (!txtHeaders.Lines[i].Contains('=')) continue;

                var tokens = txtHeaders.Lines[i].Split('=');

                request.Headers.Add(tokens[0].Trim(), tokens[1].Trim());
            }

            for (int i = 0; i < txtQuery.Lines.Count; i++)
            {
                if (!txtQuery.Lines[i].Contains('=')) continue;

                var tokens = txtQuery.Lines[i].Split('=');

                request.QueryParams.Add(tokens[0].Trim(), tokens[1].Trim());
            }

            return request;
        }

        public RequestUserControl()
        {
            InitializeComponent();
            txtId.Text = Guid.NewGuid().ToString();
        }
    }
}