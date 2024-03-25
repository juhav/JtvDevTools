using FastColoredTextBoxNS;
using JtvDevTools.Core;
using JtvDevTools.RestClient.Forms;
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
using System.Web.UI;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public partial class MainForm : Form
    {
        private int runningPageNum = 1;
        private MyAppContext myAppContext;
        private SelectRequestForm selectRequestForm;

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
            
            var uct = new RequestUserControl(myAppContext, new ApiRequest());
            uct.Dock = DockStyle.Fill;
            
            page.Controls.Add(uct);
            MainTabControl.TabPages.Add(page);
            MainTabControl.SelectedTab = page;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(TabPage p in MainTabControl.TabPages)
            {
                if ((p.Tag as string) == "VARIABLES")
                {
                    MainTabControl.SelectedTab = p;
                    return;
                }
            }

            var page = new TabPage()
            {
                Text = $"Variables",
                Tag = "VARIABLES"
            };

            var uct = new VariablesTextEditorUserControl(myAppContext);
            uct.Dock = DockStyle.Fill;

            page.Controls.Add(uct);
            MainTabControl.TabPages.Add(page);
            MainTabControl.SelectedTab = page;
        }

        private void OpenRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectRequestForm == null) selectRequestForm = new SelectRequestForm(myAppContext);

            selectRequestForm.StartPosition = FormStartPosition.CenterParent;
            selectRequestForm.SetGridDataSource();
            selectRequestForm.ShowDialog(this);

            if (selectRequestForm.SelectedRequest == null) return;

            var page = new TabPage()
            {
                Text = $"Request {runningPageNum++}"
            };

            var uct = new RequestUserControl(myAppContext, selectRequestForm.SelectedRequest);
            
            uct.Dock = DockStyle.Fill;

            page.Controls.Add(uct);
            MainTabControl.TabPages.Add(page);
            MainTabControl.SelectedTab = page;
        }

        private void ReadOpenAPISpecificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new OpenAPIForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
            //var form = new Form();

            //form.Name = "OpenAPIForm";
            //form.Text = "Read OpenAPI Specification";
            //form.Size = new Size(600, 300);
            //form.StartPosition = FormStartPosition.CenterParent;
            //form.FormBorderStyle = FormBorderStyle.FixedSingle;
            //form.MaximizeBox = false;
            //form.MinimizeBox = false;

            //form.ShowDialog(this);
        }
    }
}
