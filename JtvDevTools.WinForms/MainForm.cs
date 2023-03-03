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

namespace JtvDevTools.WinForms
{
    public partial class MainForm : Form
    {
        private Dictionary<int, TextProcessingCommandBase> commands = new Dictionary<int, TextProcessingCommandBase>();

        public MainForm()
        {
            InitializeComponent();

            commands = Utils.GetClassesOfType<TextProcessingCommandBase>().ToDictionary(x => x.Id);

        }

        public void WriteLine(string text)
        {
            txtLog.AppendText(text);
            txtLog.AppendText("\r\n");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F5)
            //{
            //    e.SuppressKeyPress = true;
            //    e.Handled = true;

            //    var lines = txtCommands.Lines.ToArray();

            //    foreach (var line in lines)
            //    {
            //        CommandHandler.ProcessCommand(line);
            //    }
            //}
        }

        private void CommandMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            if (menuItem is null) return;

            if (int.TryParse(menuItem.Tag as string, out int commandId))
            {
                var lines = txtEditor.Lines.ToArray();
                Execute(commands[commandId]);
            }
        }

        private void Execute(TextProcessingCommandBase command, TextProcessingCommandOptionsBase options = null)
        {
            var lines = txtEditor.Lines.ToArray();
            lines = command.Process(lines, options);
            txtEditor.Text = string.Join("\r\n", lines);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void PrependAppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PrependAppendForm();
            var result = form.ShowDialog(this);

            if (result != DialogResult.OK) return;

            var command = commands[Consts.Commands.PrependAppend];
            var options = new PrependAppendCommandOptions()
            {
                TextToPrepend = form.textBox1.Text,
                TextToAppend = form.textBox2.Text
            };

            Execute(command, options);
        }

        private void JoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new InputForm();
            form.lblLabel.Text = "Separator:";
            form.Text = "Join lines";
            var result = form.ShowDialog(this);

            if (result != DialogResult.OK) return;

            var command = commands[Consts.Commands.Join];
            var options = new JoinCommandOptions()
            {
                Separator = form.txtInput.Text
            };

            Execute(command, options);
        }

        private void txtLog_Enter(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowStyles[0].Height < tableLayoutPanel1.RowStyles[1].Height) return;

            this.SuspendLayout();
            var h = tableLayoutPanel1.RowStyles[0].Height;
            tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[1].Height;
            tableLayoutPanel1.RowStyles[1].Height = h;
            this.ResumeLayout();
        }

        private void txtEditor_Enter(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowStyles[1].Height < tableLayoutPanel1.RowStyles[0].Height) return;

            this.SuspendLayout();
            var h = tableLayoutPanel1.RowStyles[0].Height;
            tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[1].Height;
            tableLayoutPanel1.RowStyles[1].Height = h;
            this.ResumeLayout();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "";
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogToolStripMenuItem.Checked = !LogToolStripMenuItem.Checked;

            txtLog.Visible = LogToolStripMenuItem.Checked;

            if (!txtLog.Visible)
            {
                tableLayoutPanel1.RowStyles[1].Height = 0;
            }
            else
            {
                tableLayoutPanel1.RowStyles[1].Height = 15;
            }
        }

    }
}
