using System;
using System.Security.Cryptography;
using System.Text;
using Craftgate.Common;
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
                    var requestBody = JsonConvert.SerializeObject(request, CraftgateJsonSerializerSettings.RequestSettings);
                    hashData = decodedUrl + apiKey + secretKey + randomString + requestBody;
                }
                else
                {
                    hashData = decodedUrl + apiKey + secretKey + randomString;
                }

                HashAlgorithm algorithm = SHA256.Create();
                var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashData));
                return Convert.ToBase64String(hash);
            }
            catch (exception e)
            {
                throw new CraftgateException(e);
            }
        }

        public static string GenerateHash(string hashString)
        {
            try
            {
                using (HashAlgorithm algorithm = SHA256.Create())  
                {  
                    byte[] computeHashes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashString));

                    StringBuilder stringBuilder = new StringBuilder();

                    foreach(byte b in computeHashes)
                        stringBuilder.AppendFormat("{0:x2}", b);

                    return stringBuilder.ToString();
                }  
            }
            catch (exception e)
            {
                throw new CraftgateException(e);
            }
        }
        
        public static string GenerateWebhookSignature(string merchantHookKey, String hashString)
        {
            try
            {
                using (HashAlgorithm algorithm = new HMACSHA256(Encoding.UTF8.GetBytes(merchantHookKey)))  
                {  
                    var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashString));
                    return Convert.ToBase64String(hash);
                }  
            }
            catch (exception e)
            {
                return null;
            }
        }
        
        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}