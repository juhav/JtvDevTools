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
    public partial class ApiForm : Form
    {
        private TextBoxBehaviour nameTextBoxBehaviour;
        
        public ApiViewModel ViewModel { get; set; } = new ApiViewModel();

        public ApiForm()
        {
            InitializeComponent();

            nameTextBoxBehaviour = new TextBoxBehaviour(txtName, TextBoxType.Name, trimOnLeave: true);
        }

        public DialogResult ShowDialog(ShowFormMode mode, ApiViewModel? viewModel)
        {
            ViewModel = viewModel ?? new ApiViewModel();

            switch (mode)
            {
                case ShowFormMode.New:
                    IdTextBox.Text = ViewModel.Id.ToString();
                    dgvScopes.DataSource = ViewModel.Scopes;
                    break;

                case ShowFormMode.Edit:

                    IdTextBox.Text = ViewModel.Id.ToString();
                    txtName.Text = ViewModel.Name;
                    txtDescription.Text = ViewModel.Description;
                    dgvScopes.DataSource = ViewModel.Scopes;
                    break;
            }

            var result = ShowDialog();

            if (result == DialogResult.OK)
            {
                ViewModel.Id = new Guid(IdTextBox.Text);
                ViewModel.Name = txtName.Text;
                ViewModel.Description = txtDescription.Text;
            }

            return result;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
