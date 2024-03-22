using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace JtvDevTools.RestClient
{
    public class HttpService
    {
        public HttpService()
        {
        }

        public RestResponse Send(ApiRequest apiRequest)
        {
            if (apiRequest == null) throw new ArgumentException(nameof(apiRequest));

            var user = apiRequest.User;
            var pwd = apiRequest.Pwd;

            if (string.IsNullOrWhiteSpace(apiRequest.BaseUrl))
            {
                throw new ArgumentException("BaseUrl");
            }

            var options = new RestClientOptions()
            {
                BaseUrl = new Uri(apiRequest.BaseUrl),
                PreAuthenticate = apiRequest.PreAuthenticate,
                UseDefaultCredentials = false
            };

            switch (apiRequest.Authenticator)
            {
                case AuthenticatorType.Windows:
                    if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pwd))
                    {
                        options.Credentials = new NetworkCredential(user, pwd);
                        options.UseDefaultCredentials = false;
                    }
                    else
                    {
                        options.UseDefaultCredentials = true;
                    }
                    break;

                case AuthenticatorType.Basic:
                    if (string.IsNullOrWhiteSpace(user)) throw new ApplicationException("User is not set for BASIC authentication.");
                    if (string.IsNullOrWhiteSpace(pwd)) throw new ApplicationException("Password is not set for BASIC authentication.");

                    options.Authenticator = new HttpBasicAuthenticator(user, pwd);
                    break;
            }

            SetClientCertificate(options, apiRequest.ClientCertificate);

            var client = new RestSharp.RestClient(options);

            var request = new RestRequest(apiRequest.Resource);
            request.RequestFormat = DataFormat.Json;

            if (apiRequest.Method != HttpMethod.GET && apiRequest.Body != null)
            {
                request.AddParameter("application/json", apiRequest.Body, ParameterType.RequestBody);
            }

            SetQueryParams(request, apiRequest.QueryParams);
            SetHeaders(request, apiRequest.Headers);

            switch (apiRequest.Method)
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

        private void SetClientCertificate(RestClientOptions options, string clientCertificate)
        {
            if (string.IsNullOrWhiteSpace(clientCertificate)) return;

            X509Certificate cert;
            StoreLocation storeLocation = StoreLocation.LocalMachine;

            if (clientCertificate.Contains('|'))
            {
                var tokens = clientCertificate.Split('|');

                if (!Enum.TryParse(tokens[0], out storeLocation))
                {
                    storeLocation = StoreLocation.LocalMachine;
                }

                clientCertificate = tokens[1];
            }

            cert = Utils.GetCertificateFromStore(storeLocation, clientCertificate);

            if (cert == null) throw new ApplicationException($"Client certificate '{clientCertificate}' not found.");

            options.ClientCertificates = new X509CertificateCollection() { cert };
        }


    }
}