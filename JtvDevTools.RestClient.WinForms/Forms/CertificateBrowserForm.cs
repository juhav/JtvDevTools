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

namespace JtvDevTools.RestClient.WinForms
{
    public partial class Certificates : Form
    {
        public CertificateViewModel? SelectedCertificate { get; private set; }

        public Certificates()
        {
            InitializeComponent();
            
            var certificates = X509Helper.ListCertificates(System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);

            DataGridView.DataSource = certificates;
            SelectedCertificate = null;
        }

        private void DataGridView_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void DataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.ValueType == typeof(DateTime))
            {
                e.Column.DefaultCellStyle.Format = "d.M.yyyy HH:mm";
            }
           
            switch (e.Column.DataPropertyName)
            {
                case "NotBefore":
                    e.Column.DisplayIndex = 2;
                    break;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                var row = DataGridView.SelectedRows[0];

                SelectedCertificate = row.DataBoundItem as CertificateViewModel;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectedCertificate = null;
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
