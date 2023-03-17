using JtvDevTools.RestClient.WinForms.Core;
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

namespace JtvDevTools.RestClient.WinForms
{
    public partial class HttpRequestForm : Form
    {
        public HttpRequestForm()
        {
            InitializeComponent();
            uctHttpRequest.OnRequestChanged += uctHttpRequest_OnRequestChanged;
            btnOK.Enabled = false;
        }

        private void uctHttpRequest_OnRequestChanged()
        {
            var vm = uctHttpRequest.GetViewModel();

            btnOK.Enabled = vm.IsValid();
        }

        public DialogResult ShowDialog(ShowFormMode mode, HttpRequestViewModel? viewModel)
        {
            switch (mode)
            {
                case ShowFormMode.New:
                    uctHttpRequest.SetNewMode(); 
                    break;

                case ShowFormMode.Edit:
                    if (viewModel == null) throw new ArgumentNullException(nameof(viewModel));

                    uctHttpRequest.SetEditMode(viewModel);
                    break;
            }

            return ShowDialog();
        }

        public HttpRequestViewModel GetHttpRequestViewModel()
        {
            return uctHttpRequest.GetViewModel();
        }

        private void httpRequestUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
