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
            return RestClient.PostAsync<SettlementResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }
    }
}