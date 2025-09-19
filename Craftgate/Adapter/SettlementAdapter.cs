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

        public Task<SettlementResponse> CreateInstantWalletSettlementAsync(CreateInstantWalletSettlementRequest request)
        {
            var path = "/settlement/v1/instant-wallet-settlements";
            return AsyncRestClient.Post<SettlementResponse>(RequestOptions.BaseUrl + path, CreateHeaders(request, path, RequestOptions), request);
        }


        public PayoutAccountResponse CreatePayoutAccount(CreatePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts";
            return RestClient.Post<PayoutAccountResponse>(RequestOptions.BaseUrl + path, CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<PayoutAccountResponse> CreatePayoutAccountAsync(CreatePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts";
            return AsyncRestClient.Post<PayoutAccountResponse>(RequestOptions.BaseUrl + path, CreateHeaders(request, path, RequestOptions), request);
        }

        public void UpdatePayoutAccount(long id, UpdatePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts/" + id;
            RestClient.Put<object>(RequestOptions.BaseUrl + path, CreateHeaders(request, path, RequestOptions), request);
        }

        public Task UpdatePayoutAccountAsync(long id, UpdatePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts/" + id;
            return AsyncRestClient.Put<object>(RequestOptions.BaseUrl + path, CreateHeaders(request, path, RequestOptions), request);
        }

        public void DeletePayoutAccount(long id)
        {
            var path = "/settlement/v1/payout-accounts/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task DeletePayoutAccountAsync(long id)
        {
            var path = "/settlement/v1/payout-accounts/" + id;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public PayoutAccountListResponse SearchPayoutAccounts(SearchPayoutAccountRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/payout-accounts" + queryParam;
            return RestClient.Get<PayoutAccountListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PayoutAccountListResponse> SearchPayoutAccountsAsync(SearchPayoutAccountRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/payout-accounts" + queryParam;
            return AsyncRestClient.Get<PayoutAccountListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}