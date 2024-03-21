using JtvDevTools.Core;
using JtvDevTools.RestClient.Models;
using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.LiteDB
{

    public class LiteDB : IDatabase
    {
        private class Collections
        {
            public const string Request = "Request";
            public const string Variable = "Variable";
        }

        private readonly string databaseFileName;

        public LiteDB(string databaseFileName)
        {

            this.databaseFileName = databaseFileName;   
        }

        public void SaveRequest(ApiRequest request)
        {
            var doc = new BsonDocument();

            doc["_id"] = request.Id;
            doc["ApiName"] = request.ApiName;
            doc["BaseUrl"] = request.BaseUrl;
            doc["Body"] = request.Body;
            doc["ClientCertificate"] = request.ClientCertificate;
            doc["Method"] = (int)request.Method;
            doc["Name"] = request.Name;
            doc["PreAuthenticate"] = request.PreAuthenticate;
            doc["PrettyPrint"] = request.PrettyPrint;
            doc["Resource"] = request.Resource;

            // HEADERS
            var headers = new BsonDocument();
            foreach (var kvpair in request.Headers)
            {
                headers[kvpair.Key] = kvpair.Value;    
            }
            doc["Headers"] = headers;

            // QUERY PARAMS
            var queryParams = new BsonDocument();
            foreach (var kvpair in request.Headers)
            {
                queryParams[kvpair.Key] = kvpair.Value;
            }
            doc["Query"] = queryParams;

            //doc[""] = request.;
            //doc[""] = request.;
            //doc[""] = request.;
            //doc[""] = request.;

            Upsert(Collections.Request, doc);
        }

        public void InitializeDatabase()
        {
            using (var db = new LiteDatabase($"Filename={databaseFileName}"))
            {
                db.GetCollection(Collections.Request);
                db.GetCollection(Collections.Variable);

            }
        }

        public void SaveVariables(IEnumerable<Variable> variables)
        {
            if (variables == null) return;

            using (var db = new LiteDatabase($"Filename={databaseFileName}"))
            {
                var col = db.GetCollection(Collections.Variable);

                col.DeleteAll();

                foreach (var variable in variables)
                {
                    var doc = new BsonDocument();

                    doc["_id"] = variable.Name;
                    doc["Value"] = variable.Value;
                
                    col.Upsert(doc);
                }
            }
        }

        public void DeleteVariable(Variable variable)
        {
            if (variable  == null) return;

            Delete(Collections.Variable, variable.Name);
        }

        private void Upsert(string collectionName, BsonDocument doc)
        {
            using (var db = new LiteDatabase($"Filename={databaseFileName}"))
            {
                var col = db.GetCollection(collectionName);

                col.Upsert(doc);
            }
        }

        private void Delete(string collectionName, BsonValue id)
        {
            using (var db = new LiteDatabase($"Filename={databaseFileName}"))
            {
                var col = db.GetCollection(collectionName);

                col.Delete(id);
            }
        }

        public void SaveVariable(Variable variable)
        {
            if (variable == null) return;

            var doc = new BsonDocument();

            doc["_id"] = variable.Name;
            doc["Value"] = variable.Value;

            Upsert(Collections.Variable, doc);
        }

        public Dictionary<string, string> LoadVariables()
        {
            var result = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

            using (var db = new LiteDatabase($"Filename={databaseFileName}"))
            {
                var col = db.GetCollection(Collections.Variable);

                var docs = col.FindAll();

                foreach (var doc in docs)
                {
                    string name = doc["_id"];
                    string value = doc["Value"];
                    
                    result.Add(name, value);
                }
            }

            return result;
        }

    }
}
