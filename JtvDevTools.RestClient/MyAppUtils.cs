using JtvDevTools.RestClient.LiteDB;
using System.IO;

namespace JtvDevTools.RestClient
{
    public static class MyAppUtils
    {
        public static IDatabase CreateDatabase(string databaseFileName)
        {
            IDatabase result = null;

            if (!File.Exists(databaseFileName))
            {
                result = new LiteDB.LiteDB(databaseFileName);
                result.InitializeDatabase();
            }
            else
            {
                result = new LiteDB.LiteDB(databaseFileName);
            }

            return result;
        }
    }
}
