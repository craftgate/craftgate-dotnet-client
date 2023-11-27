using System;
using System.Threading.Tasks;
using Craftgate.Model;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class MerchantAdapter : BaseAdapter
    {
        public MerchantAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public MerchantPosResponse CreateMerchantPos(CreateMerchantPosRequest createMemberRequest)
        {
            var path = "/merchant/v1/merchant-poses";
            return RestClient.Post<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMemberRequest, path, RequestOptions),
                createMemberRequest);
        }

        public Task<MerchantPosResponse> CreateMerchantPosAsync(CreateMerchantPosRequest createMemberRequest)
        {
            var path = "/merchant/v1/merchant-poses";
            return AsyncRestClient.Post<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMemberRequest, path, RequestOptions),
                createMemberRequest);
        }

        public MerchantPosResponse RetrieveMerchantPos(long id)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            return RestClient.Get<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MerchantPosResponse> RetrieveMerchantPosAsync(long id)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            return AsyncRestClient.Get<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MerchantPosResponse UpdateMerchantPos(long id, UpdateMerchantPosRequest updateMerchantPosRequest)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            return RestClient.Put<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMerchantPosRequest, path, RequestOptions),
                updateMerchantPosRequest);
        }

        public Task<MerchantPosResponse> UpdateMerchantPosAsync(long id,
            UpdateMerchantPosRequest updateMerchantPosRequest)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            return AsyncRestClient.Put<MerchantPosResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMerchantPosRequest, path, RequestOptions),
                updateMerchantPosRequest);
        }

        public void UpdateMerchantPosStatus(long id, PosStatus posStatus)
        {
            var path = "/merchant/v1/merchant-poses/" + id + "/status/" + posStatus;
            RestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void UpdateMerchantPosStatusAsync(long id, PosStatus posStatus)
        {
            var path = "/merchant/v1/merchant-poses/" + id + "/status/" + posStatus;
            AsyncRestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteMerchantPos(long id)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteMerchantPosAsync(long id)
        {
            var path = "/merchant/v1/merchant-poses/" + id;
            AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MerchantPosListResponse SearchMerchantPos(SearchMerchantPosRequest searchMerchantPosRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMerchantPosRequest);
            var path = "/merchant/v1/merchant-poses" + queryParam;
            return RestClient.Get<MerchantPosListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MerchantPosListResponse> SearchMerchantPosAsync(SearchMerchantPosRequest searchMerchantPosRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMerchantPosRequest);
            var path = "/merchant/v1/merchant-poses" + queryParam;
            return AsyncRestClient.Get<MerchantPosListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MerchantPosCommissionListResponse RetrieveMerchantPosCommissions(long id)
        {
            var path = "/merchant/v1/merchant-poses/" + id + "/commissions";
            return RestClient.Get<MerchantPosCommissionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        /*
        * This endpoint using for creating and updating merchant pos commissions. The HTTP method is POST due to this requirement.
        * */
        public MerchantPosCommissionListResponse UpdateMerchantPosCommissions(long id,
            UpdateMerchantPosCommissionsRequest request)
        {
            var path = "/merchant/v1/merchant-poses/" + id + "/commissions";
            return RestClient.Post<MerchantPosCommissionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions),
                request);
        }
    }
}