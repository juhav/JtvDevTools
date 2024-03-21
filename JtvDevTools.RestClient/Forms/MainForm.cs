using FastColoredTextBoxNS;
using JtvDevTools.Core;
using JtvDevTools.RestClient.UserControls;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public partial class MainForm : Form
    {
        private readonly string appDataFolder;
        private int runningPageNum = 1;
        private MyAppContext myAppContext;

        public MainForm()
        {
            InitializeComponent();

            myAppContext = new MyAppContext();
            myAppContext.CreateDatabase();
            myAppContext.LoadData();
        }

        private void NewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = new TabPage()
            {
                Text = $"Request {runningPageNum++}"
            };
            
            var uct = new RequestUserControl(myAppContext);
            uct.Dock = DockStyle.Fill;
            
            page.Controls.Add(uct);
            MainTabControl.TabPages.Add(page);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save
        }

        private void APIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Edit APIs
        }

        private void CredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Edit Credentials
        }

        private void VariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = new TabPage()
            {
                Text = $"Variables"
            };

            var uct = new VariablesTextEditorUserControl(myAppContext);
            uct.Dock = DockStyle.Fill;

            page.Controls.Add(uct);
            MainTabControl.TabPages.Add(page);
        }

        private void OpenRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open
        }
    }
}
