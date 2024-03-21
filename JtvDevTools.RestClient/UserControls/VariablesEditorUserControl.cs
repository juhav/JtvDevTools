using JtvDevTools.Core;
using JtvDevTools.RestClient.Forms;
using JtvDevTools.RestClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.UserControls
{
    public partial class VariablesEditorUserControl : UserControl
    {
        //private MyAppContext myAppContext;
        //private VariableForm variableForm;
        //private JtvBindingList<Variable> variablesBindingList;
        //private BindingSource variablesBindingSource;

        public VariablesEditorUserControl(MyAppContext myAppContext)
        {
            InitializeComponent();

            //this.myAppContext = myAppContext;

            //variablesBindingList = new JtvBindingList<Variable>(myAppContext.Variables);
            //variablesBindingSource = new BindingSource(variablesBindingList, null);
            //dgvEditor.AutoGenerateColumns = false;
            //dgvEditor.DataSource = variablesBindingSource;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var tabPage = this.Parent as TabPage;
            var tabControl = tabPage.Parent as TabControl;

            tabPage.Controls.Clear();

            tabControl.TabPages.Remove(tabPage);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //var dict = new Dictionary<string, Variable>(StringComparer.InvariantCultureIgnoreCase);

            //foreach (var item in variablesBindingList.DeletedItems)
            //{
            //    myAppContext.Database.DeleteVariable(item as Variable);
            //}

            //foreach (var variable in variablesBindingList)
            //{
            //    if (string.IsNullOrEmpty(variable.Name)) continue;

            //    if (dict.ContainsKey(variable.Name))
            //    {
            //        MessageBox.Show($"Failed to save variables. Duplicate variable [{variable.Name}].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    dict.Add(variable.Name, variable);
            //}

            //var variables = dict.Values.ToList();

            //myAppContext.Database.SaveVariables(variables);

            //myAppContext.Variables = variables;
        }

        private void dgvEditor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                var value = dgvEditor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string;

                if (value != null)
                {
                    dgvEditor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value.Trim();
                }
            }
        }

        private void AddSecretVariableButton_Click(object sender, EventArgs e)
        {
            //if (variableForm == null)
            //{
            //    variableForm = new VariableForm();
            //    variableForm.StartPosition = FormStartPosition.CenterParent;
            //}

            //variableForm.Clear();
            //variableForm.SetModeToSecret();

            //var result = variableForm.ShowDialog(this);

            //if (result == DialogResult.OK)
            //{
            //    var v = new Variable()
            //    {
            //        IsSecret = true,
            //        Name = variableForm.VariableName,
            //        Value = variableForm.VariableValue
            //    };

            //    variablesBindingList.Add(v);
            //}
        }

        private void dgvEditor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //var item = dgvEditor.Rows[e.RowIndex].DataBoundItem;

            //if (item == null) return;
            //if (e.ColumnIndex == 0) return;

            //if (item is Variable v)
            //{

            //    if (v.IsSecret)
            //    {
            //        e.Value = "(secret)";
            //        e.FormattingApplied = true;
            //    }
            //}

        }

        private void dgvEditor_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //var item = dgvEditor.Rows[e.RowIndex].DataBoundItem;

            //if (item == null) return;

            //if (item is Variable v)
            //{
            //    if (v.IsSecret)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            //if (dgvEditor.CurrentCell == null) return;

            //if (dgvEditor.Rows[dgvEditor.CurrentCell.RowIndex].DataBoundItem is Variable v)
            //{
            //    variablesBindingList.Remove(v);
            //}

        }

        private void dgvEditor_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                if (dgvEditor.Rows[e.RowIndex].DataBoundItem is Variable variable)
                {

                }
            }
            catch { }
        }

        private void dgvEditor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEditor_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.FormattedValue is string value)
            //{
            //    value = value.Trim();

            //    if (dgvEditor.Rows[e.RowIndex].DataBoundItem is Variable variable)
            //    {
            //        if (variablesBindingList.Any(v => v.Id != variable.Id && string.Equals(v.Name, value, StringComparison.InvariantCultureIgnoreCase)))
            //        {
            //            MessageBox.Show("Can't add duplicate variable.", "Variables", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            e.Cancel = true;
            //        }
            //    }

            //}
        }
    }

    public class JtvBindingList<T> : BindingList<T> where T : ModelBase
    {
        private List<ModelBase> deletedItems = new List<ModelBase>();

        public List<ModelBase> DeletedItems 
        {
            get => deletedItems;
        }

        public JtvBindingList(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                this.Items.Add(item);
            }
        }

        protected override void RemoveItem(int index)
        {
            ModelBase item = Items[index];

            if (!item.IsNew)
            {
                item.IsDeleted = true;
                deletedItems.Add(item);
            }

            base.RemoveItem(index);
        }

    }
}
