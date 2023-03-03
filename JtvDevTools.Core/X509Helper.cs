using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Core;

public static class X509Helper
{
    public static Result<string> Encrypt(StoreLocation storeLocation, string certificateName, string plainText)
    {
        if (string.IsNullOrWhiteSpace(certificateName))
        {
            return new Result<string>("", false, "Certificate is missing.");
        }

        X509Certificate2 certificate = GetCertificateFromStore(storeLocation, certificateName);

        if (certificate == null)
        {
            return new Result<string>("", false, $"Certificate not found {certificateName}.");
        }

        try
        {
            string cipherText = null;
            byte[] strBytes = Encoding.UTF8.GetBytes(plainText);

            using (RSA rsa = certificate.GetRSAPublicKey())
            {
                // OAEP allows for multiple hashing algorithms, what was formermly just "OAEP" is now OAEP-SHA1.
                cipherText = Convert.ToBase64String(rsa.Encrypt(strBytes, RSAEncryptionPadding.OaepSHA256));
            }

            return new Result<string>(cipherText);
        }
        catch (Exception ex)
        {
            return new Result<string>("", false, ex.Message);
        }
    }

    public static Result<string> Decrypt(StoreLocation storeLocation, string certificateName, string cipherText)
    {
        if (string.IsNullOrWhiteSpace(certificateName))
        {
            return new Result<string>("", false, "Certificate is missing.");
        }

        X509Certificate2 certificate = GetCertificateFromStore(storeLocation, certificateName);

        if (certificate == null)
        {
            return new Result<string>("", false, $"Certificate not found {certificateName}.");
        }

        try
        {
            string plainText;
            byte[] strBytes = Convert.FromBase64String(cipherText);
            RSA? rsa = null;

            try
            {
                rsa = certificate.GetRSAPrivateKey();
                plainText = Encoding.UTF8.GetString(rsa!.Decrypt(strBytes, RSAEncryptionPadding.OaepSHA256));

                return new Result<string>(plainText);
            }
            catch
            {
                return new Result<string>("", false, $"Unable to get private key. Check private key read permissions.");
            }
            finally
            {
                try
                {
                    if (rsa != null)
                    {
                        rsa.Dispose();
                        rsa = null;
                    }
                }
                catch
                {
                }
            }
        }
        catch (Exception ex)
        {
            return new Result<string>("", false, ex.Message);
        }
    }

    public static List<CertificateViewModel> ListCertificates(StoreLocation storeLocation, string findStr = null)
    {
        var result = new List<CertificateViewModel>();
        X509Store certStore = new X509Store(storeLocation);
        certStore.Open(OpenFlags.ReadOnly);

        foreach (var cert in certStore.Certificates)
        {
            var name = cert.GetNameInfo(X509NameType.SimpleName, false);

            if (findStr != null)
            {
                if (!name.ToLowerInvariant().Contains(findStr) && !cert.Thumbprint.ToLowerInvariant().Contains(findStr) && !cert.FriendlyName.ToLowerInvariant().Contains(findStr))
                {
                    continue;
                }
            }

            var certVM = new CertificateViewModel()
            {
                FriendlyName = cert.FriendlyName,
                Name = name,
                NotAfter = cert.NotAfter,
                NotBefore = cert.NotBefore,
                Subject = cert.Subject,
                Thumbprint = cert.Thumbprint
            };

            result.Add(certVM);
        }

        return result;
    }

    public static X509Certificate2 GetCertificateFromStore(StoreLocation storeLocation, string thumbprintOrName)
    {
        X509Store certStore = new X509Store(storeLocation);
        certStore.Open(OpenFlags.ReadOnly);

        foreach (var cert in certStore.Certificates)
        {
            if (cert.Thumbprint.Equals(thumbprintOrName, StringComparison.InvariantCultureIgnoreCase))
            {
                return cert;
            }
        }

        foreach (var cert in certStore.Certificates)
        {
            if (cert.FriendlyName.Equals(thumbprintOrName, StringComparison.InvariantCultureIgnoreCase))
            {
                return cert;
            }
        }

        return null;
    }
}