using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Core
{
    public static class Utils
    {
        public static Dictionary<string, string> GetKeyValuePairs(string text)
        {
            var result = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

            string[] lines = text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var s = line.Trim();

                if (s.Length == 0) continue;
                if (s.StartsWith("#")) continue;

                if (s.Contains('='))
                {
                    var tokens = s.Split(new char[] { '=' }, 2);

                    tokens[0] = tokens[0].Trim().ToUpperInvariant();
                    tokens[1] = tokens[1].Trim();

                    result.Add(tokens[0], tokens[1]);
                }
            }

            return result;
        }

        public static void GetKeyValuePair(string s, out string key, out string value)
        {
            key = "";
            value = "";

            if (string.IsNullOrEmpty(s)) return;

            if (s.Contains('='))
            {
                var tokens = s.Split(new char[] { '=' }, 2);

                key = tokens[0].Trim();
                value = tokens[1].Trim();
            }
        }

        public static string FileToBase64(string filename)
        {
            if (File.Exists(filename))
            {
                var bytes = File.ReadAllBytes(filename);
                var result = Convert.ToBase64String(bytes);

                return result;
            }

            return null;
        }

        public static string PrettyJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return "";

            string result = "";

            try
            {
                dynamic parsedJson = (JsonConvert.DeserializeObject(json));
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            catch
            {
                result = json;
            }

            return result;
        }

        public static string PrettyXML(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml)) return "";

            string result = "";
            MemoryStream memoryStream = null;
            System.Xml.XmlTextWriter writer = null;

            try
            {
                memoryStream = new MemoryStream(xml.Length + 8192);
                writer = new System.Xml.XmlTextWriter(memoryStream, Encoding.Unicode);
                var document = new System.Xml.XmlDocument();

                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = System.Xml.Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                memoryStream.Flush();

                // Have to rewind the MemoryStream in order to read its contents.
                memoryStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader reader = new StreamReader(memoryStream);

                // Extract the text from the StreamReader.
                string formattedXml = reader.ReadToEnd();

                result = formattedXml;
            }
            catch
            {
                result = xml;
            }
            finally
            {
                try
                {
                    if (memoryStream != null) memoryStream.Close();
                    if (writer != null) writer.Close();
                }
                catch
                {
                }
            }

            return result;
        }

        /// <summary>
        /// Get certificate from given store by it's name or thumbprint.
        /// </summary>
        /// <param name="storeLocation">Store: CurrentUser or LocalMachine</param>
        /// <param name="nameOrThumbprint">Name or thumbprint (case insensitive and thumbprint must not contain spaces).</param>
        /// <returns></returns>
        public static X509Certificate2 GetCertificateFromStore(StoreLocation storeLocation, string nameOrThumbprint)
        {
            if (string.IsNullOrWhiteSpace(nameOrThumbprint)) return null;

            StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase;
            X509Store certStore = new X509Store(storeLocation);
            certStore.Open(OpenFlags.ReadOnly);

            foreach (var cert in certStore.Certificates)
            {
                if (cert.Thumbprint.Equals(nameOrThumbprint, stringComparison))
                {
                    return cert;
                }
                if (cert.GetNameInfo(X509NameType.SimpleName, false).Equals(nameOrThumbprint, stringComparison))
                {
                    return cert;
                }
            }

            return null;
        }

        public static string Encrypt(X509Certificate2 cert, string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            using (RSA rsa = cert.GetRSAPublicKey())
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                return Convert.ToBase64String(rsa.Encrypt(bytes, RSAEncryptionPadding.OaepSHA256));
            }
        }

        public static string Decrypt(X509Certificate2 cert, string text)
        {
            using (RSA rsa = cert.GetRSAPrivateKey())
            {
                var bytes = Convert.FromBase64String(text);
                return Encoding.UTF8.GetString(rsa.Decrypt(bytes, RSAEncryptionPadding.OaepSHA256));
            }
        }

        public static string GetMyDocumentsAbsoluteFileName(string folder, string fileName)
        {
            if (string.IsNullOrWhiteSpace(folder)) return null;
            if (string.IsNullOrWhiteSpace(fileName)) return null;

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, folder);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var absoluteFileName = Path.Combine(path, fileName);

            return absoluteFileName;
        }

    }
}