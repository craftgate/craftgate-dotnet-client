using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;
using Craftgate.Response.Dto;

namespace Craftgate.Adapter
{
    public class PaymentAdapter : BaseAdapter
    {
        public PaymentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public PaymentResponse CreatePayment(CreatePaymentRequest createPaymentRequest)
        {
            var path = "/payment/v1/card-payments";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createPaymentRequest, path, RequestOptions),
                createPaymentRequest);
        }

        public PaymentResponse RetrievePayment(long id)
        {
            var path = "/payment/v1/card-payments/" + id;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public InitThreeDSPaymentResponse Init3DSPayment(InitThreeDSPaymentRequest initThreeDSPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-init";
            return RestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initThreeDSPaymentRequest, path, RequestOptions),
                initThreeDSPaymentRequest);
        }

        public PaymentResponse Complete3DSPayment(CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-complete";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public DepositPaymentResponse CreateDepositPayment(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public DepositPaymentRefundResponse RefundDepositPayment(long paymentId,
            RefundDepositPaymentRequest refundDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/" + paymentId + "/refunds";
            return RestClient.Post<DepositPaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundDepositPaymentRequest, path, RequestOptions),
                refundDepositPaymentRequest);
        }

        public InitThreeDSPaymentResponse Init3DSDepositPayment(InitThreeDSPaymentRequest initThreeDSPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-init";
            return RestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initThreeDSPaymentRequest, path, RequestOptions),
                initThreeDSPaymentRequest);
        }

        public DepositPaymentResponse Complete3DSDepositPayment(
            CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-complete";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public PaymentTransactionRefundResponse RefundPaymentTransaction(
            RefundPaymentTransactionRequest refundPaymentTransactionRequest)
        {
            var path = "/payment/v1/refund-transactions";
            return RestClient.Post<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentTransactionRequest, path, RequestOptions),
                refundPaymentTransactionRequest);
        }

        public PaymentTransactionRefundResponse RetrievePaymentTransactionRefund(long id)
        {
            var path = "/payment/v1/refund-transactions/" + id;
            return RestClient.Get<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionRefundListResponse SearchPaymentTransactionRefunds(
            SearchPaymentTransactionRefundsRequest searchPaymentTransactionRefundsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentTransactionRefundsRequest);
            var path = "/payment/v1/refund-transactions" + query;

            return RestClient.Get<PaymentTransactionRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentRefundResponse RefundPayment(RefundPaymentRequest refundPaymentRequest)
        {
            var path = "/payment/v1/refunds";
            return RestClient.Post<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentRequest, path, RequestOptions),
                refundPaymentRequest);
        }

        public PaymentRefundResponse RetrievePaymentRefund(long id)
        {
            var path = "/payment/v1/refunds/" + id;
            return RestClient.Get<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public StoredCardResponse StoreCard(StoreCardRequest storeCardRequest)
        {
            var path = "/payment/v1/cards";
            return RestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(storeCardRequest, path, RequestOptions), storeCardRequest);
        }

        public StoredCardListResponse SearchStoredCards(SearchStoredCardsRequest searchStoredCardsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchStoredCardsRequest);
            var path = "/payment/v1/cards" + query;

            return RestClient.Get<StoredCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteStoredCard(DeleteStoredCardRequest deleteStoredCardRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(deleteStoredCardRequest);
            var path = "/payment/v1/cards" + query;

            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionApprovalListResponse ApprovePaymentTransactions(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public PaymentTransactionApprovalListResponse DisapprovePaymentTransactions(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/disapprove";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }
    }
}