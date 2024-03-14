using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Core
{

    public class ApiRequest
    {
        private Dictionary<string, string> headers = new Dictionary<string, string>();
        private Dictionary<string, string> queryParams = new Dictionary<string, string>();

        private Dictionary<string, string> baseUrls = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        private string authenticatorName = "";
        private string apiName = "";
        private string baseUrl = "";
        private string clientCertificate = "";
        private string name = "";
        private string resource = "";

        public string AuthenticatorName
        {
            get => authenticatorName;
            set => authenticatorName = (value ?? "").Trim().ToUpperInvariant();
        }

        public string ApiName
        {
            get => apiName;
            set => apiName = (value ?? "").Trim();
        }

        public string BaseUrl
        {
            get => baseUrl;
            set => baseUrl = (value ?? "").Trim().TrimEnd('/').ToLowerInvariant();
        }

        public Dictionary<string, string> BaseUrls
        {
            get => baseUrls;
            set => baseUrls = (value ?? new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase));
        }

        public string Body
        {
            get;
            set;
        }

        public string ClientCertificate
        {
            get => clientCertificate;
            set => clientCertificate = FormatThumbprint(value);
        }

        public int ExpectedStatusCode
        {
            get;
            set;
        }

        public Dictionary<string, string> Headers
        {
            get => headers;
            set => headers = (value != null ? value : new Dictionary<string, string>());
        }

        public Guid Id
        {
            get;
            set;
        }

        public HttpMethod Method
        {
            get;
            set;
        }

        public string Name
        {
            get => name;
            set => name = (value ?? "").Trim();
        }

        public RequestOutputMode OutputMode
        {
            get;
            set;
        }

        public bool PreAuthenticate
        {
            get;
            set;
        }

        public bool PrettyPrint
        {
            get;
            set;
        }

        public string Pwd
        {
            get;
            set;
        }

        public Dictionary<string, string> QueryParams
        {
            get => queryParams;
            set => queryParams = (value != null ? value : new Dictionary<string, string>());
        }

        public string Resource
        {
            get => resource;
            set => resource = (value ?? "").Trim().TrimStart('/');
        }

        public string SaveResponseBodyToFile
        {
            get;
            set;
        }

        public string User
        {
            get;
            set;
        }

        public ApiRequest()
        {
            Id = Guid.NewGuid();
            ExpectedStatusCode = 200;
        }

        public override string ToString()
        {
            var sb = new StringBuilder(1024);

            sb.AppendLine("[BaseUrls]");
            foreach (var url in BaseUrls)
            {
                sb.AppendLine($"{url.Key} = {url.Value}");
            }

            sb.AppendLine("");


            sb.AppendLine("[Request]");
            sb.AppendLine($"Id = {Id.ToString()}");
            sb.AppendLine($"Name = {Name}");
            sb.AppendLine($"API = {ApiName}");
            sb.AppendLine($"Method = {Method.ToString().ToUpperInvariant()}");
            sb.AppendLine($"BaseUrl = {BaseUrl}");
            sb.AppendLine($"Resource = {Resource}");
            sb.AppendLine($"Auth = {AuthenticatorName}");
            sb.AppendLine($"User = {User}");
            sb.AppendLine($"Pwd = {Pwd}");
            sb.AppendLine($"ClientCertificate = {ClientCertificate}");
            sb.AppendLine($"PrettyPrint = {PrettyPrint}");
            sb.AppendLine($"PreAuthenticate = {PreAuthenticate}");
            sb.AppendLine($"ExpectedStatusCode = {ExpectedStatusCode}");
            sb.AppendLine($"SaveResponseBodyToFile = {SaveResponseBodyToFile}");
            sb.AppendLine();

            sb.AppendLine("[Headers]");
            foreach (var kvpair in headers)
            {
                sb.AppendLine($"{kvpair.Key} = {kvpair.Value}");
            }
            sb.AppendLine();

            sb.AppendLine("[Query]");
            foreach (var kvpair in queryParams)
            {
                sb.AppendLine($"{kvpair.Key} = {kvpair.Value}");
            }
            sb.AppendLine();

            return sb.ToString();
        }

        private static string FormatThumbprint(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";

            var sb = new StringBuilder(128);

            foreach (var c in value)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLowerInvariant(c));
                }
            }

            return sb.ToString();
        }
    }


    public class ApiResponse
    {
        public int StatusCode { get; set; }

        public int TimeElapsed { get; set; }
    }

    public class ApiOperationTest
    {
        public ApiRequest ApiRequest { get; set; }

        public ApiResponse ApiResponse { get; set; }

    }
}