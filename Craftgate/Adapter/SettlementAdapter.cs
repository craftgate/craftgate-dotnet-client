using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class SettlementAdapter : BaseAdapter
    {
        public SettlementAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public SettlementResponse CreateInstantWalletSettlement(
            CreateInstantWalletSettlementRequest request)
        {
            var path = "/settlement/v1/instant-wallet-settlements";
            return RestClient.Post<SettlementResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<SettlementResponse> CreateInstantWalletSettlementAsync(
            CreateInstantWalletSettlementRequest request)
        {
            var path = "/settlement/v1/instant-wallet-settlements";
            return AsyncRestClient.Post<SettlementResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public SettlementRowListResponse SearchSettlementRows(SearchSettlementRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/settlements/rows" + queryParam;
            return RestClient.Get<SettlementRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<SettlementRowListResponse> SearchSettlementRowsAsync(SearchSettlementRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/settlements/rows" + queryParam;
            return AsyncRestClient.Get<SettlementRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}