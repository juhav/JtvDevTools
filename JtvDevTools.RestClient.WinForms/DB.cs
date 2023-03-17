using JtvDevTools.Core;
using JtvDevTools.RestClient.WinForms.Models;
using JtvDevTools.RestClient.WinForms.UserControls;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms;

public interface IDB
{
    void DeleteRequest(Guid id);
    void DeleteVariable(Guid id);

    List<HttpRequest> GetRequests();
    List<Variable> GetVariables();

    void SaveRequest(HttpRequest request);
    void SaveVariable(Variable variable);

}

public class LiteDB : IDB
{
    private class Collections
    {
        public const string Requests = "requests";
        public const string Variables = "variables";
    }

    private readonly string connectionString;

    public LiteDB(string connectionString)
    {
        if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));

        this.connectionString = connectionString;
    }

    public void DeleteRequest(Guid id)
    {
        Delete(id, Collections.Requests);
    }

    public void DeleteVariable(Guid id)
    {
        Delete(id, Collections.Variables);
    }


    public List<HttpRequest> GetRequests()
    {
        return Get<HttpRequest>(Collections.Requests);
    }

    public List<Variable> GetVariables()
    {
        return Get<Variable>(Collections.Variables);
    }

    public void SaveRequest(HttpRequest request)
    {
        Save(request, Collections.Requests);
    }

    public void SaveVariable(Variable variable)
    {
        Save(variable, Collections.Variables);
    }

    public void Delete(Guid id, string collection) 
    {
        if (id == Guid.Empty) throw new ArgumentException("Id is empty guid.");

        using (var db = new LiteDatabase(connectionString))
        {
            var col = db.GetCollection(collection);

            col.Delete(id);
        }
    }

    public List<T> Get<T>(string collection)
    {
        List<T> result;

        using (var db = new LiteDatabase(connectionString))
        {
            var col = db.GetCollection<T>(collection);
            
            result = col.FindAll().ToList();
        }

        return result;
    }

    public void Save<T>(T model, string collection) where T : IModel
    {
        if (model == null) throw new ArgumentNullException(nameof(model));
        if (model.Id == Guid.Empty) throw new ArgumentException("Model.Id is empty guid.");

        using (var db = new LiteDatabase(connectionString))
        {
            var col = db.GetCollection<T>(collection);

            col.Upsert(model);
        }
    }


}
