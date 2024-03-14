using JtvDevTools.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.WinForms.Forms
{
    public partial class ParametersForm : Form
    {
        private DataTable dt;

        public ParametersForm()
        {
            InitializeComponent();
        }

        public DialogResult Show(TextProcessingCommandParameters commandParameters)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn() { ColumnName = "Name", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Value", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Type", DataType = typeof(int) });

            foreach (var p in commandParameters.Dictionary.Values)
            {
                var row = dt.NewRow();

                row[0] = p.Name;
                row[1] = p.Value;
                row[2] = (int)p.ParameterType;

                dt.Rows.Add(row);
            }

            DataGrid.DataSource = dt;

            var result = this.ShowDialog();

            foreach (DataRow row in dt.Rows)
            {
                var key = row[0] as string;
                var value = row[1] as string;

                commandParameters.Dictionary[key].Value = value;
            }

            return result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ErrorLabel.Text != "") return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 1) return;

            ErrorLabel.Text = "";
            DataGrid[e.ColumnIndex, e.RowIndex].Tag = null;

            var row = dt.Rows[e.RowIndex];
            var value = row[1] as string;
            var ptype = (TextProcessingCommandParameterType)((int)row[2]);

            if (ptype == TextProcessingCommandParameterType.Bool)
            {
                DataGrid.EditingControl.Text = DataGrid.EditingControl.Text.Trim();
                var s = DataGrid.EditingControl.Text;

                if (s != "true" && s != "false")
                {
                    ErrorLabel.Text = "Value must be true or false.";
                    DataGrid[e.ColumnIndex, e.RowIndex].Tag = 1;


                }
            }
        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
