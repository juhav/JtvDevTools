using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public static class WindowsFormsHelper
    {
        public static string PickFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return dialog.FileName;
                }
            }

            return "";
        }

        public static string PickFolder()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }

            return "";
        }

        public static string GetAppDataFolder()
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "JtvRestClient");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }

        public static FastColoredTextBox GetContextMenuSourceTextBox(object sender)
        {
            try
            {
                return (((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl as FastColoredTextBox);
            }
            catch
            {
                return null;
            }
        }

        public static void InsertTextToFastColoredTextBox(FastColoredTextBox target, string text)
        {
            if (target == null || string.IsNullOrEmpty(text)) return;

            try
            {
                target.InsertText(text);
            }
            catch
            {
            }
        }
    }
}
