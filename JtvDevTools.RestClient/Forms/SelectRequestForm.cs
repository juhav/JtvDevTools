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
    public partial class SelectRequestForm : Form
    {
        private readonly MyAppContext myAppContext;
        private readonly DataTable dt;

        public ApiRequest SelectedRequest { get; private set; }

        public SelectRequestForm(MyAppContext myAppContext)
        {
            InitializeComponent();

            this.myAppContext = myAppContext;

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("API", typeof(string));
            dt.Columns.Add("Method", typeof(string));
            dt.Columns.Add("BaseUrl", typeof(string));
            dt.Columns.Add("Resource", typeof(string));
        }

        public void SetGridDataSource()
        {
            SelectedRequest = null;
            dgvRequests.DataSource = null;
            dt.Rows.Clear();

            foreach (var request in myAppContext.Requests.Values)
            {
                var row = dt.NewRow();

                row["Id"] = request.Id;
                row["API"] = request.ApiName;
                row["Method"] = request.Method.ToString();
                row["BaseUrl"] = request.BaseUrl;
                row["Resource"] = request.Resource;

                dt.Rows.Add(row);
            }

            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = dt;
           
        }

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRequests.CurrentRow == null) return;

            if (dgvRequests.CurrentRow.DataBoundItem is DataRowView drv)
            {
                var id = (drv.Row["Id"] as Guid?).GetValueOrDefault(Guid.Empty);
                SelectedRequest = myAppContext.Requests[id];    

                this.Close();
            }
        }

        private void dgvRequests_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.DataPropertyName == "Id")
            {
                e.Column.Visible = false;
            }
        }

        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.Handled = true;
                e.SuppressKeyPress = true;
                Search();
            }
        }

        private void Search()
        {
            if (string.IsNullOrWhiteSpace(SearchToolStripTextBox.Text))
            {
                dt.DefaultView.RowFilter = null;
            }
            else
            {
                dt.DefaultView.RowFilter = $"API LIKE '%{SearchToolStripTextBox.Text}%'";
            }
        }

    }
}
