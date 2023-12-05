using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.WinForms
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
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "JtvDevTools");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }
    }
}
