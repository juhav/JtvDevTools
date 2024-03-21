using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.Forms
{
    public partial class SelectVariableForm : Form
    {
        private readonly MyAppContext myAppContext;
        private readonly DataTable dt;

        public string SelectedVariable
        {
            get;
            private set;
        }

        public SelectVariableForm(MyAppContext myAppContext)
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            
            this.myAppContext = myAppContext;
        }

        public void SetGridDataSource()
        {
            dgvVariables.DataSource = null;
            dt.Rows.Clear();

            foreach (var kv in myAppContext.Variables)
            {
                var row = dt.NewRow();

                row["Name"] = kv.Key;
                row["Value"] = kv.Value;

                dt.Rows.Add(row);
            }

            dgvVariables.DataSource = dt;
        }

        private void dgvVariables_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void dgvVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvVariables.CurrentRow == null) return;

            if (dgvVariables.CurrentRow.DataBoundItem is DataRowView drv)
            {
                SelectedVariable = drv.Row["Name"] as string;
                this.Close();
            }
        }
    }
}
