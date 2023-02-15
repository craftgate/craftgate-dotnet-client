using System.Threading.Tasks;
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
        
        public WalletResponse CreateMemberWallet(long memberId, CreateWalletRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/members/" + memberId + "/wallets";
            return RestClient.Post<WalletResponse>(RequestOptions.BaseUrl + path, CreateHeaders(createRemittanceRequest, path, RequestOptions), createRemittanceRequest);
        }

        public WalletResponse RetrieveMemberWallet(long memberId)
        {
            var path = "/wallet/v1/members/" + memberId + "/wallet";
            return RestClient.Get<WalletResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task<WalletResponse> RetrieveMemberWalletAsync(long memberId)
        {
            var path = "/wallet/v1/members/" + memberId + "/wallet";
            return AsyncRestClient.Get<WalletResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public WalletTransactionListResponse SearchWalletTransactions(long walletId,
            SearchWalletTransactionsRequest searchWalletTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchWalletTransactionsRequest);
            var path = "/wallet/v1/wallets/" + walletId + "/wallet-transactions" + queryParam;
            return RestClient.Get<WalletTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<WalletTransactionListResponse> SearchWalletTransactionsAsync(long walletId,
            SearchWalletTransactionsRequest searchWalletTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchWalletTransactionsRequest);
            var path = "/wallet/v1/wallets/" + walletId + "/wallet-transactions" + queryParam;
            return AsyncRestClient.Get<WalletTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public RemittanceResponse SendRemittance(CreateRemittanceRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/remittances/send";
            return RestClient.Post<RemittanceResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createRemittanceRequest, path, RequestOptions),
                createRemittanceRequest);
        }

        public Task<RemittanceResponse> SendRemittanceAsync(CreateRemittanceRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/remittances/send";
            return AsyncRestClient.Post<RemittanceResponse>(RequestOptions.BaseUrl + path,
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

        public Task<RemittanceResponse> ReceiveRemittanceAsync(CreateRemittanceRequest createRemittanceRequest)
        {
            var path = "/wallet/v1/remittances/receive";
            return AsyncRestClient.Post<RemittanceResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createRemittanceRequest, path, RequestOptions),
                createRemittanceRequest);
        }

        public RemittanceResponse RetrieveRemittance(long id)
        {
            var path = "/wallet/v1/remittances/" + id;
            return RestClient.Get<RemittanceResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task<RemittanceResponse> RetrieveRemittanceAsync(long id)
        {
            var path = "/wallet/v1/remittances/" + id;
            return AsyncRestClient.Get<RemittanceResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public WalletResponse RetrieveMerchantMemberWallet()
        {
            var path = "/wallet/v1/merchants/me/wallet";
            return RestClient.Get<WalletResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task<WalletResponse> RetrieveMerchantMemberWalletAsync()
        {
            var path = "/wallet/v1/merchants/me/wallet";
            return AsyncRestClient.Get<WalletResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public WalletResponse ResetMerchantMemberWalletBalance(ResetMerchantMemberWalletBalanceRequest request)
        {
            var path = "/wallet/v1/merchants/me/wallet/reset-balance";
            return RestClient.Post<WalletResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<WalletResponse> ResetMerchantMemberWalletBalanceAsync(ResetMerchantMemberWalletBalanceRequest request)
        {
            var path = "/wallet/v1/merchants/me/wallet/reset-balance";
            return AsyncRestClient.Post<WalletResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public WalletTransactionRefundableAmountResponse RetrieveRefundableAmountOfWalletTransaction(
            long walletTransactionId)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refundable-amount";
            return RestClient.Get<WalletTransactionRefundableAmountResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<WalletTransactionRefundableAmountResponse> RetrieveRefundableAmountOfWalletTransactionAsync(
            long walletTransactionId)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refundable-amount";
            return AsyncRestClient.Get<WalletTransactionRefundableAmountResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public RefundWalletTransactionToCardResponse RefundWalletTransactionToCard(long walletTransactionId,
            RefundWalletTransactionToCardRequest request)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refunds";
            return RestClient.Post<RefundWalletTransactionToCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<RefundWalletTransactionToCardResponse> RefundWalletTransactionToCardAsync(long walletTransactionId,
            RefundWalletTransactionToCardRequest request)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refunds";
            return AsyncRestClient.Post<RefundWalletTransactionToCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public RefundWalletTransactionToCardListResponse RetrieveRefundWalletTransactionsToCard(
            long walletTransactionId)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refunds";
            return RestClient.Get<RefundWalletTransactionToCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<RefundWalletTransactionToCardListResponse> RetrieveRefundWalletTransactionsToCardAsync(
            long walletTransactionId)
        {
            var path = "/payment/v1/wallet-transactions/" + walletTransactionId + "/refunds";
            return AsyncRestClient.Get<RefundWalletTransactionToCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public WithdrawResponse CreateWithdraw(CreateWithdrawRequest request)
        {
            var path = "/wallet/v1/withdraws";
            return RestClient.Post<WithdrawResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<WithdrawResponse> CreateWithdrawAsync(CreateWithdrawRequest request)
        {
            var path = "/wallet/v1/withdraws";
            return AsyncRestClient.Post<WithdrawResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public WithdrawResponse CancelWithdraw(long withdrawId)
        {
            var path = "/wallet/v1/withdraws/" + withdrawId + "/cancel";
            return RestClient.Post<WithdrawResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<WithdrawResponse> CancelWithdrawAsync(long withdrawId)
        {
            var path = "/wallet/v1/withdraws/" + withdrawId + "/cancel";
            return AsyncRestClient.Post<WithdrawResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public WithdrawResponse RetrieveWithdraw(long withdrawId)
        {
            var path = "/wallet/v1/withdraws/" + withdrawId;
            return RestClient.Get<WithdrawResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task<WithdrawResponse> RetrieveWithdrawAsync(long withdrawId)
        {
            var path = "/wallet/v1/withdraws/" + withdrawId;
            return AsyncRestClient.Get<WithdrawResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public WithdrawListResponse SearchWithdraws(SearchWithdrawsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/wallet/v1/withdraws" + queryParam;
            return RestClient.Get<WithdrawListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<WithdrawListResponse> SearchWithdrawsAsync(SearchWithdrawsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/wallet/v1/withdraws" + queryParam;
            return AsyncRestClient.Get<WithdrawListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}