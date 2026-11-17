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