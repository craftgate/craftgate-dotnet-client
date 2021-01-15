using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class WalletAdapter : BaseAdapter
    {
        public WalletAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public WalletListResponse SearchWallets(SearchWalletsRequest searchWalletsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchWalletsRequest);
            var path = "/wallet/v1/wallets" + queryParam;
            return RestClient.Get<WalletListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public WalletTransactionListResponse SearchWalletTransactions(long walletId,
            SearchWalletTransactionsRequest searchWalletTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchWalletTransactionsRequest);
            var path = "/wallet/v1/wallets/" + walletId + "/wallet-transactions" + queryParam;
            return RestClient.Get<WalletTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public RemittanceResponse SendRemittance(CreateRemittanceRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/remittances/send";
            return RestClient.Post<RemittanceResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createRemittanceRequest, path, RequestOptions),
                createRemittanceRequest);
        }

        public RemittanceResponse ReceiveRemittance(CreateRemittanceRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/remittances/receive";
            return RestClient.Post<RemittanceResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createRemittanceRequest, path, RequestOptions),
                createRemittanceRequest);
        }
    }
}