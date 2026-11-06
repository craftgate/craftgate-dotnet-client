using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class SettlementReportingAdapter : BaseAdapter
    {
        public SettlementReportingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public PayoutCompletedItemListResponse SearchPayoutCompletedItems(
            SearchPayoutCompletedItemsRequest searchPayoutCompletedItemsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedItemsRequest);
            var path = "/settlement-reporting/v1/settlement-file/payout-completed-items" + queryParam;
            return RestClient.Get<PayoutCompletedItemListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPayoutCompletedItemsRequest, path, RequestOptions));
        }

        public Task<PayoutCompletedItemListResponse> SearchPayoutCompletedItemsAsync(
            SearchPayoutCompletedItemsRequest searchPayoutCompletedItemsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedItemsRequest);
            var path = "/settlement-reporting/v1/settlement-file/payout-completed-items" + queryParam;
            return AsyncRestClient.Get<PayoutCompletedItemListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPayoutCompletedItemsRequest, path, RequestOptions));
        }

        public PayoutBouncedTransactionListResponse SearchBouncedPayoutTransactions(
            SearchPayoutBouncedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + queryParam;
            return RestClient.Get<PayoutBouncedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPayoutCompletedTransactionsRequest, path, RequestOptions));
        }

        public Task<PayoutBouncedTransactionListResponse> SearchBouncedPayoutTransactionsAsync(
            SearchPayoutBouncedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + queryParam;
            return AsyncRestClient.Get<PayoutBouncedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPayoutCompletedTransactionsRequest, path, RequestOptions));
        }

        public SettlementRowResponse RetrieveSettlementRow(long settlementRowId)
        {
            var path = "/settlement-reporting/v1/settlement-file/rows/" + settlementRowId;
            return RestClient.Get<SettlementRowResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<SettlementRowResponse> RetrieveSettlementRowAsync(long settlementRowId)
        {
            var path = "/settlement-reporting/v1/settlement-file/rows/" + settlementRowId;
            return AsyncRestClient.Get<SettlementRowResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PayoutRowListResponse SearchPayoutRows(SearchPayoutRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement-reporting/v1/settlement-file-rows" + queryParam;
            return RestClient.Get<PayoutRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public Task<PayoutRowListResponse> SearchPayoutRowsAsync(SearchPayoutRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement-reporting/v1/settlement-file-rows" + queryParam;
            return AsyncRestClient.Get<PayoutRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(request, path, RequestOptions));
        }

        public PaymentTxPayoutResponse RetrievePaymentTransactionPayout(long paymentTransactionId)
        {
            var path = "/settlement-reporting/v1/payment-transactions/" + paymentTransactionId + "/payout";
            return RestClient.Get<PaymentTxPayoutResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PaymentTxPayoutResponse> RetrievePaymentTransactionPayoutAsync(long paymentTransactionId)
        {
            var path = "/settlement-reporting/v1/payment-transactions/" + paymentTransactionId + "/payout";
            return AsyncRestClient.Get<PaymentTxPayoutResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentTxPayoutListResponse SearchPaymentTransactionPayouts(
            SearchPaymentTransactionPayoutsRequest searchPaymentTransactionPayoutsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentTransactionPayoutsRequest);
            var path = "/settlement-reporting/v1/payment-transactions/payouts" + queryParam;
            return RestClient.Get<PaymentTxPayoutListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPaymentTransactionPayoutsRequest, path, RequestOptions));
        }

        public Task<PaymentTxPayoutListResponse> SearchPaymentTransactionPayoutsAsync(
            SearchPaymentTransactionPayoutsRequest searchPaymentTransactionPayoutsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentTransactionPayoutsRequest);
            var path = "/settlement-reporting/v1/payment-transactions/payouts" + queryParam;
            return AsyncRestClient.Get<PaymentTxPayoutListResponse>(RequestOptions.BaseUrl + path,
                CreateHeadersWithoutBody(searchPaymentTransactionPayoutsRequest, path, RequestOptions));
        }
    }
}