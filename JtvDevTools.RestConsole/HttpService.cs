using JtvDevTools.RestConsole.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HttpMethod = JtvDevTools.RestConsole.Models.HttpMethod;

namespace JtvDevTools.RestConsole;

public class HttpService
{
    public HttpService()
    {
    }

    public RestResponse Send(ApiOperation operation)
    {
        if (operation == null) return null;

        var baseUrl = operation.BaseUrl;
        var user = operation.User;
        var pwd = operation.Pwd;
        var authenticatorName = operation.AuthenticatorName;

        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            throw new ArgumentException(nameof(baseUrl));
        }

        var client = new RestClient(baseUrl);
        client.Options.UseDefaultCredentials = operation.UseDefaultCredentials;
        
        var request = new RestRequest(operation.Resource);
        request.RequestFormat = DataFormat.Json;

        switch (authenticatorName)
        {
            case "NTLM":
                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pwd))
                {
                    client.Options.Credentials = new NetworkCredential(user, pwd);
                }
                break;

            case "BASIC":
                client.Options.UseDefaultCredentials = false;
                client.Authenticator = new HttpBasicAuthenticator(user, pwd);
                break;
        }

        if (operation.Method != HttpMethod.GET && operation.Body != null)
        {
            request.AddParameter("application/json", operation.Body, ParameterType.RequestBody);
        }

        SetQueryParams(request, operation.QueryParams);
        SetHeaders(request, operation.Headers);
        SetClientCertificate(client, operation.ClientCertificate);

        switch (operation.Method)
        {
            case HttpMethod.GET:
                return client.Get(request);
            case HttpMethod.POST:
                return client.Post(request);
            case HttpMethod.PUT:
                return client.Put(request);
            case HttpMethod.DELETE:
                return client.Delete(request);
            default:
                throw new ApplicationException("Method not supported.");
        }
    }

    private void SetHeaders(RestRequest request, Dictionary<string, string> headers)
    {
        if (headers == null) return;
        
        foreach (var kvpair in headers)
        {
            request.AddHeader(kvpair.Key, kvpair.Value);
        }
    }

    private void SetQueryParams(RestRequest request, Dictionary<string, string> queryParams)
    {
        if (queryParams == null) return;

        foreach (var kvpair in queryParams)
        {
            request.AddQueryParameter(kvpair.Key, kvpair.Value);
        }
    }

    private void SetClientCertificate(RestClient client, string? clientCertificate)
    {
        
        if (string.IsNullOrWhiteSpace(clientCertificate)) return;
        
        X509Certificate cert;
        StoreLocation storeLocation = StoreLocation.LocalMachine;

        if (clientCertificate.Contains('|'))
        {
            var tokens = clientCertificate.Split('|', 2);

            if (!Enum.TryParse(tokens[0], out storeLocation))
            {
                storeLocation = StoreLocation.LocalMachine;
            }

            clientCertificate = tokens[1];
        }

        cert = Utils.GetCertificateFromStore(storeLocation, clientCertificate);
        client.Options.ClientCertificates!.Add(cert);
    }

    
}
