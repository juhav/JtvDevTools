using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.Forms
{
    public partial class VariableForm : Form
    {
        public string VariableName
        {
            get => VariableNameTextBox.Text;
        }

        public string VariableValue
        {
            get => VariableValueTextBox.Text;
        }

        public VariableForm()
        {
            InitializeComponent();
        }

        internal void Clear()
        {
            VariableNameTextBox.Text = "";
            VariableValueTextBox.Text = "";
        }

        private void VariableNameTextBox_Leave(object sender, EventArgs e)
        {
            VariableNameTextBox.Text = VariableNameTextBox.Text.Trim();
        }

        public void SetModeToSecret()
        {
            VariableValueTextBox.UseSystemPasswordChar = true;
        }

        public void SetModeToNormal()
        {
            VariableValueTextBox.UseSystemPasswordChar = false;
        }

    }
}
