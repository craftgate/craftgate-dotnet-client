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

        public void DeletePayoutAccount(DeletePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts/" + request.Id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public Task DeletePayoutAccountAsync(DeletePayoutAccountRequest request)
        {
            var path = "/settlement/v1/payout-accounts/" + request.Id;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public PayoutAccountListResponse SearchPayoutAccounts(SearchPayoutAccountRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/payout-accounts" + queryParam;
            return RestClient.Get<PayoutAccountListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public Task<PayoutAccountListResponse> SearchPayoutAccountsAsync(SearchPayoutAccountRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/payout-accounts" + queryParam;
            return AsyncRestClient.Get<PayoutAccountListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public PaymentTransactionApprovalListResponse ApprovePaymentTransactions(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/settlement/v1/payment-transactions/approve";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public Task<PaymentTransactionApprovalListResponse> ApprovePaymentTransactionsAsync(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/settlement/v1/payment-transactions/approve";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public PaymentTransactionApprovalListResponse DisapprovePaymentTransactions(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/settlement/v1/payment-transactions/disapprove";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public Task<PaymentTransactionApprovalListResponse> DisapprovePaymentTransactionsAsync(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/settlement/v1/payment-transactions/disapprove";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public PaymentTxPayoutResponse UpdatePaymentTransaction(
            UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/settlement/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return RestClient.Put<PaymentTxPayoutResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }

        public Task<PaymentTxPayoutResponse> UpdatePaymentTransactionAsync(
            UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/settlement/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return AsyncRestClient.Put<PaymentTxPayoutResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }
    }
}