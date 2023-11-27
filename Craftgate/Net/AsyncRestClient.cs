using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Craftgate.Exception;
using exception = System.Exception;

namespace Craftgate.Net
{
    public class AsyncRestClient : BaseRestClient
    {
        public static Task<T> Get<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Get, headers, null);
        }

        public static Task<T> Post<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, request);
        }

        public static Task<T> Post<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, null);
        }

        public static Task<T> Put<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Put, headers, request);
        }

        public static void Put<T>(string url, Dictionary<string, string> headers)
        {
            Exchange<T>(url, HttpMethod.Put, headers, null);
        }

        public static Task Delete<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Delete, headers, null);
        }

        private static async Task<T> Exchange<T>(string url, HttpMethod httpMethod, Dictionary<string, string> headers,
            object request)
        {
            try
            {
                var requestMessage = BuildHttpRequestMessage(url, httpMethod, headers, request);
                var httpResponseMessage = await HttpClient.SendAsync(requestMessage);
                var content = await httpResponseMessage.Content.ReadAsByteArrayAsync();
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