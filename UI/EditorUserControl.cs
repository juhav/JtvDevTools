using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools
{
    public interface IConsoleCommandHandler
    {
        void ProcessCommand(string text);
    }

    public interface IConsoleOutput
    {
        void WriteLine(string text);
    }

    public partial class EditorUserControl : UserControl, IConsoleCommandHandler
    {
        public IConsoleOutput Console { get; set; }

        public EditorUserControl()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(Exception exception)
        {
            MessageBox.Show(exception.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NewGuidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtEditor.InsertText(Guid.NewGuid().ToString() + "\r\n");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void FormatJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.FormatJSON(txtEditor.Text);

                txtEditor.Text = result;

                ConsoleWriteLine("Format json completed.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }


        private void TrimLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = txtEditor.Lines.ToArray();
                TextProcessor.Trim(lines);
                txtEditor.Text = string.Join("\r\n", lines);

                ConsoleWriteLine("Trim all lines completed.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void removeEmptyLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = txtEditor.Lines.ToArray();
                lines = TextProcessor.RemoveEmptyLines(lines);
                txtEditor.Text = string.Join("\r\n", lines);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void Base64EncodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.Base64Encode(txtEditor.Text);
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }

        }

        private void Base64DecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.Base64Decode(txtEditor.Text);
                txtEditor.Text = result;

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void SqlInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.SqlInClause(txtEditor.Lines.ToArray());
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void SqlInStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.SqlInClauseApostrophe(txtEditor.Lines.ToArray());
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        public void ProcessCommand(string text)
        {
            var tokens = text.Split(' ');

            switch (tokens[0])
            {
                case "append":
                    var result = TextProcessor.Append(txtEditor.Lines.ToArray(), tokens[1]);
                    txtEditor.Text = result;
                    break;

                case "format-json":
                    FormatJsonToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case "trim":
                    TrimLinesToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case "new-guid":
                case "newguid":
                    NewGuidToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;

            }
        }

        private void ConsoleWriteLine(string message)
        {
            if (Console != null)
            {
                Console.WriteLine(message);
            }
        }

        private void AppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.Append(txtEditor.Lines.ToArray(), "");
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void PrependToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.Prepend(txtEditor.Lines.ToArray(), "");
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void AppendPrependToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = TextProcessor.AppendPrepend(txtEditor.Lines.ToArray(), "", "");
                txtEditor.Text = result;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }
    }
}
