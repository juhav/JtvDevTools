using JtvDevTools.Core;
using JtvDevTools.RestClient.LiteDB;
using JtvDevTools.RestClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public class MyAppContext
    {
        private readonly string appDataFolder;
        private readonly string databaseFileName;

        public IDatabase Database { get; private set; }

        public Dictionary<string, string> Variables { get; set; }

        public Dictionary<Guid, ApiRequest> Requests { get; set; }

        public MyAppContext()
        {
            appDataFolder = WindowsFormsHelper.GetAppDataFolder();
            databaseFileName = Path.Combine(appDataFolder, "jtvrc.db");
            Variables = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        }

        public void CreateDatabase()
        {
            Database = MyAppUtils.CreateDatabase(databaseFileName);
            //var msg = $"Database was not found. Following file will be created: {databaseFileName}";

            //MessageBox.Show(msg, "First run");
        }

        public void LoadData()
        {
            Variables = Database.LoadVariables();
            Requests = Database.LoadRequests();
        }
    }
}
