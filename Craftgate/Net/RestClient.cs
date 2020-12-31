using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Craftgate.Exception;
using Craftgate.Response.Common;
using Newtonsoft.Json;
using exception = System.Exception;

namespace Craftgate.Net
{
    public static class RestClient
    {
        private static readonly HttpClient HttpClient;

        static RestClient()
        {
#if !NETSTANDARD1_3
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            var handler = new HttpClientHandler {AllowAutoRedirect = false};
            HttpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(120)
            };
        }

        public static T Get<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Get, headers, null);
        }

        public static T Post<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, request);
        }

        public static T Put<T>(string url, Dictionary<string, string> headers, object request)
        {
            return Exchange<T>(url, HttpMethod.Put, headers, request);
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
                var requestMessage = new HttpRequestMessage
                {
                    Method = httpMethod,
                    RequestUri = new Uri(url),
                    Content = PrepareContent(request)
                };
                foreach (var header in headers) requestMessage.Headers.Add(header.Key, header.Value);
                var httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
                return HandleResponse<T>(httpResponseMessage);
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

        private static T HandleResponse<T>(HttpResponseMessage httpResponseMessage)
        {
            var apiResponse =
                JsonConvert.DeserializeObject<Response<T>>(httpResponseMessage.Content.ReadAsStringAsync().Result);

            if (apiResponse == null) return default;
            if (apiResponse.Errors != null)
            {
                var errorResponse = apiResponse.Errors;
                throw new CraftgateException(errorResponse.ErrorCode, errorResponse.ErrorDescription,
                    errorResponse.ErrorGroup);
            }

            return apiResponse.Data;
        }

        private static StringContent PrepareContent(object request)
        {
            if (request == null) return null;
            var body = JsonConvert.SerializeObject(request);
            return new StringContent(body, Encoding.UTF8, "application/json");
        }
    }
}