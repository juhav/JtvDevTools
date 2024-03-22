using JtvDevTools.Core;
using JtvDevTools.RestClient.Models;
using System;
using System.Collections.Generic;

namespace JtvDevTools.RestClient
{
    public interface IDatabase
    {

        Dictionary<string, string> LoadVariables();

        void SaveRequest(ApiRequest request);
        void SaveVariables(IEnumerable<Variable> request);

        void InitializeDatabase();

        void SaveVariable(Variable variable);
        void DeleteVariable(Variable variable);
        Dictionary<Guid, ApiRequest> LoadRequests();
    }
}
