using System;
using System.Security.Cryptography;
using System.Text;
using Craftgate.Exception;
using Newtonsoft.Json;
using exception = System.Exception;

namespace Craftgate.Request.Common
{
    public static class HashGenerator
    {
        public static string GenerateHash(string baseUrl, string apiKey, string secretKey, string randomString,
            object request, string path)
        {
            try
            {
                string hashData;

                var decodedUrl = Uri.UnescapeDataString(baseUrl + path);

                if (request != null)
                {
                    var requestBody = JsonConvert.SerializeObject(request);
                    hashData = decodedUrl + apiKey + secretKey + randomString + requestBody;
                }
                else
                {
                    hashData = decodedUrl + apiKey + secretKey + randomString;
                }

                HashAlgorithm algorithm = SHA256.Create();
                var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashData));
                return Convert.ToBase64String(hash).ToUpper();
            }
            catch (exception e)
            {
                throw new CraftgateException(e);
            }
        }
    }
}