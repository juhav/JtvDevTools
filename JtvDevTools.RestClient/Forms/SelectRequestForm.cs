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
        private bool ignoreEvents = false;
        private string filterText = "";
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
            dt.Columns.Add("Name", typeof(string));
        }

        public void SetGridDataSource()
        {
            ignoreEvents = true;
            SelectedRequest = null;
            dgvRequests.DataSource = null;
            dt.Rows.Clear();

            var hashset = new HashSet<string>();
            foreach (var request in myAppContext.Requests.Values)
            {
                var row = dt.NewRow();

                row["Id"] = request.Id;
                row["API"] = request.ApiName;
                row["Method"] = request.Method.ToString();
                row["BaseUrl"] = request.BaseUrl;
                row["Resource"] = request.Resource;
                row["Name"] = request.Name;

                dt.Rows.Add(row);

                hashset.Add(request.ApiName);
            }

            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = dt;
           
            ignoreEvents = false;
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
            switch (e.Column.DataPropertyName)
            {
                case "Id":
                    e.Column.Visible = false;
                    break;

                case "BaseUrl":
                    e.Column.Width = 250;
                    break;

                case "Name":
                    e.Column.Width = 250;
                    break;
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
            filterText = SearchToolStripTextBox.Text;

            if (string.IsNullOrWhiteSpace(filterText))
            { 
                dt.DefaultView.RowFilter = null;
            }
            else
            {
                dt.DefaultView.RowFilter = $"API LIKE '%{filterText}%' OR Name LIKE '%{filterText}%'";
            }
        }

        private void APIFilterToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchToolStripTextBox_Leave(object sender, EventArgs e)
        {
            if (filterText != SearchToolStripTextBox.Text)
            {
                SearchToolStripTextBox.Text = filterText;
            }
        }
    }
}
