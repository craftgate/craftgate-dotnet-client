using System;
using System.Threading.Tasks;
using Craftgate.Model;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class MerchantApmAdapter : BaseAdapter
    {
        public MerchantApmAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public MerchantApmResponse CreateMerchantApm(CreateMerchantApmRequest createMerchantApmRequest)
        {
            var path = "/merchant/v1/merchant-apms";
            return RestClient.Post<MerchantApmResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMerchantApmRequest, path, RequestOptions),
                createMerchantApmRequest);
        }

        public Task<MerchantApmResponse> CreateMerchantApmAsync(CreateMerchantApmRequest createMerchantApmRequest)
        {
            var path = "/merchant/v1/merchant-apms";
            return AsyncRestClient.Post<MerchantApmResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMerchantApmRequest, path, RequestOptions),
                createMerchantApmRequest);
        }

        public MerchantApmListResponse RetrieveMerchantApm()
        {
            var path = "/merchant/v1/merchant-apms";
            return RestClient.Get<MerchantApmListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MerchantApmListResponse> RetrieveMerchantPosAsync()
        {
            var path = "/merchant/v1/merchant-apms";
            return AsyncRestClient.Get<MerchantApmListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MerchantApmResponse UpdateMerchantApm(long id, UpdateMerchantApmRequest updateMerchantApmRequest)
        {
            var path = "/merchant/v1/merchant-apms/" + id;
            return RestClient.Put<MerchantApmResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMerchantApmRequest, path, RequestOptions),
                updateMerchantApmRequest);
        }

        public Task<MerchantApmResponse> UpdateMerchantApmAsync(long id,
            UpdateMerchantApmRequest updateMerchantApmRequest)
        {
            var path = "/merchant/v1/merchant-apms/" + id;
            return AsyncRestClient.Put<MerchantApmResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMerchantApmRequest, path, RequestOptions),
                updateMerchantApmRequest);
        }

        public void UpdateMerchantApmStatus(long id, UpdateMerchantApmStatusRequest updateMerchantApmStatusRequest)
        {
            var path = "/merchant/v1/merchant-apms/" + id + "/status";
            
            RestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMerchantApmStatusRequest, path, RequestOptions),
                updateMerchantApmStatusRequest);
        }

        public void UpdateMerchantApmStatusAsync(long id, PosStatus posStatus)
        {
            var path = "/merchant/v1/merchant-apms/" + id + "/status/" + posStatus;
            AsyncRestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteMerchantApm(long id)
        {
            var path = "/merchant/v1/merchant-apms/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteMerchantApmAsync(long id)
        {
            var path = "/merchant/v1/merchant-apms/" + id;
            AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}