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

        public PayoutBouncedTransactionListResponse SearchBouncedPayoutTransactions(
            SearchPayoutBouncedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + queryParam;
            return RestClient.Get<PayoutBouncedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}