using JtvDevTools.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public partial class SelectCertificateForm : Form
    {
        public string CertificateThumbprint { get; private set; }

        public SelectCertificateForm()
        {
            InitializeComponent();

            var certificates = X509Helper.ListCertificates(StoreLocation.LocalMachine);
            
            foreach (var cert in certificates) 
            {
                var item = new ListViewItem()
                {
                    Text = cert.FriendlyName
                };

                item.SubItems.Add(cert.Name);
                item.SubItems.Add(cert.NotBefore.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
                item.SubItems.Add(cert.NotAfter.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
                item.SubItems.Add(cert.Subject);
                item.SubItems.Add(cert.Thumbprint);

                lvwCerts.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvwCerts.SelectedItems.Count > 0)
            {
                CertificateThumbprint = lvwCerts.SelectedItems[0].SubItems[5].Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
