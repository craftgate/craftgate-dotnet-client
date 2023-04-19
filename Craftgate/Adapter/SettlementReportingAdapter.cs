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

        public PayoutCompletedTransactionListResponse SearchPayoutCompletedTransactions(
            SearchPayoutCompletedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/payout-completed-transactions" + queryParam;
            return RestClient.Get<PayoutCompletedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PayoutCompletedTransactionListResponse> SearchPayoutCompletedTransactionsAsync(
            SearchPayoutCompletedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/payout-completed-transactions" + queryParam;
            return AsyncRestClient.Get<PayoutCompletedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PayoutBouncedTransactionListResponse SearchBouncedPayoutTransactions(
            SearchPayoutBouncedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + queryParam;
            return RestClient.Get<PayoutBouncedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PayoutBouncedTransactionListResponse> SearchBouncedPayoutTransactionsAsync(
            SearchPayoutBouncedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + queryParam;
            return AsyncRestClient.Get<PayoutBouncedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PayoutDetailResponse RetrievePayoutDetails(long id)
        {
            var path = "/settlement-reporting/v1/settlement-file/payout-details/" + id;
            return RestClient.Get<PayoutDetailResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PayoutDetailResponse> RetrievePayoutDetailsAsync(long id)
        {
            var path = "/settlement-reporting/v1/settlement-file/payout-details/" + id;
            return AsyncRestClient.Get<PayoutDetailResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
        
        public PayoutRowListResponse SearchPayoutRows(SearchPayoutRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement-reporting/v1/settlement-file-rows" + queryParam;
            return RestClient.Get<PayoutRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PayoutRowListResponse> SearchPayoutRowsAsync(SearchPayoutRowsRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/settlement/v1/settlements/rows" + queryParam;
            return AsyncRestClient.Get<PayoutRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}