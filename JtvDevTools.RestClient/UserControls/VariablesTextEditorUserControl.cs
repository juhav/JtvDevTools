using JtvDevTools.Core;
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
    public partial class VariablesTextEditorUserControl : UserControl
    {
        private readonly MyAppContext myAppContext;
        
        public VariablesTextEditorUserControl(MyAppContext myAppContext)
        {
            InitializeComponent();

            this.myAppContext = myAppContext;

            txtEditor.Text = "";

            var sb = new StringBuilder(4096);
            foreach (var kv in this.myAppContext.Variables)
            {
                sb.Append(kv.Key);
                sb.Append(" = ");
                sb.AppendLine(kv.Value);
            }
            txtEditor.Text = sb.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

            for (int i=0; i<txtEditor.Lines.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(txtEditor.Lines[i])) continue;
                if (!txtEditor.Lines[i].Contains('=')) continue;

                Utils.GetKeyValuePair(txtEditor.Lines[i], out string key, out string value);

                if (string.IsNullOrWhiteSpace(key)) continue;
                if (string.IsNullOrWhiteSpace(value)) continue;

                dict.Add(key, value);
            }

            var list = new List<Variable>(dict.Count);
            foreach (var kvpair in dict)
            {
                var variable = new Variable(kvpair.Key, kvpair.Value);
                list.Add(variable);
            }

            list = list.OrderBy(i => i.Name).ToList();

            myAppContext.Database.SaveVariables(list);
            myAppContext.LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var tabPage = this.Parent as TabPage;
            var tabControl = tabPage.Parent as TabControl;

            tabPage.Controls.Clear();

            tabControl.TabPages.Remove(tabPage);
        }
    }
}
