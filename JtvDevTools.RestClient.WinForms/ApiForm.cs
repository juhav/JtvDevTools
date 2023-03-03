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
        private ApiViewModel viewModel = new ApiViewModel();
        private TextBoxBehaviour nameTextBoxBehaviour;
        
        public ApiViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = (value ?? new ApiViewModel());

            }
        }

        public ApiForm()
        {
            InitializeComponent();

            nameTextBoxBehaviour = new TextBoxBehaviour(txtName, TextBoxType.Name, trimOnLeave: true);
        }

        private void GetViewModelFromUI()
        {
            viewModel.Id = new Guid(IdTextBox.Text);
            viewModel.Name = txtName.Text;
            viewModel.Description = txtDescription.Text;
        }

        private void SetViewModelToUI()
        {
            IdTextBox.Text = viewModel.Id.ToString();
            txtName.Text = viewModel.Name;
            txtDescription.Text = viewModel.Description;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GetViewModelFromUI();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ApiForm_Shown(object sender, EventArgs e)
        {
            SetViewModelToUI();
        }
    }
}
