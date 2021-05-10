using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class PaymentReportingAdapter : BaseAdapter
    {
        public PaymentReportingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public ReportingPaymentListResponse SearchPayments(SearchPaymentsRequest searchPaymentsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentsRequest);
            var path = "/payment-reporting/v1/payments" + queryParam;
            return RestClient.Get<ReportingPaymentListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentResponse RetrievePayment(long paymentId)
        {
            var path = "/payment-reporting/v1/payments/" + paymentId;
            return RestClient.Get<ReportingPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentTransactionListResponse RetrievePaymentTransactions(long paymentId)
        {
            var path = "/payment-reporting/v1/payments/" + paymentId + "/transactions";
            return RestClient.Get<ReportingPaymentTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentRefundListResponse RetrievePaymentRefunds(long paymentId)
        {
            var path = "/payment-reporting/v1/payments/" + paymentId + "/refunds";
            return RestClient.Get<ReportingPaymentRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentTransactionRefundListResponse RetrievePaymentTransactionRefunds(long paymentId,
            long paymentTransactionId)
        {
            var path = "/payment-reporting/v1/payments/" + paymentId + "/transactions/" + paymentTransactionId +
                       "/refunds";
            return RestClient.Get<ReportingPaymentTransactionRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentRefundListResponse SearchPaymentRefunds(
            SearchPaymentRefundsRequest searchPaymentRefundsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentRefundsRequest);
            var path = "/payment-reporting/v1/refunds" + queryParam;
            return RestClient.Get<ReportingPaymentRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public ReportingPaymentTransactionRefundListResponse SearchPaymentTransactionRefunds(
            SearchPaymentTransactionRefundsRequest searchPaymentTransactionRefundsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentTransactionRefundsRequest);
            var path = "/payment-reporting/v1/refund-transactions" + queryParam;
            return RestClient.Get<ReportingPaymentTransactionRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}