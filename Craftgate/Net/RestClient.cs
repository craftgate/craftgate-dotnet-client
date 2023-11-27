using System.Collections.Generic;
using System.Net.Http;
using Craftgate.Exception;
using exception = System.Exception;

namespace Craftgate.Net
{
    public class RestClient : BaseRestClient
    {
        public static T Get<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Get, headers, null);
        }

        public static T Post<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, request);
        }

        public static T Post<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, null);
        }

        public static T Put<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Put, headers, request);
        }
        
        public static T Put<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Put, headers, null);
        }

        public static void Delete<T>(string url, Dictionary<string, string> headers)
        {
            Exchange<T>(url, HttpMethod.Delete, headers, null);
        }

        private static T Exchange<T>(string url, HttpMethod httpMethod, Dictionary<string, string> headers,
            object request)
        {
            try
            {
                var requestMessage = BuildHttpRequestMessage(url, httpMethod, headers, request);
                var httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
                var content = httpResponseMessage.Content.ReadAsByteArrayAsync().Result;
                return HandleResponse<T>(httpResponseMessage, content);
            }
            catch (CraftgateException e)
            {
                throw e;
            }
            catch (exception e)
            {
                throw new CraftgateException(e);
            }
        }
    }
}