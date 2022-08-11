using System.Threading.Tasks;
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

        public Task<PaymentResponse> CreatePaymentAsync(CreatePaymentRequest createPaymentRequest)
        {
            var path = "/payment/v1/card-payments";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createPaymentRequest, path, RequestOptions),
                createPaymentRequest);
        }

        public PaymentResponse RetrievePayment(long id)
        {
            var path = "/payment/v1/card-payments/" + id;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PaymentResponse> RetrievePaymentAsync(long id)
        {
            var path = "/payment/v1/card-payments/" + id;
            return AsyncRestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public InitThreeDSPaymentResponse Init3DSPayment(InitThreeDSPaymentRequest initThreeDSPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-init";
            return RestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initThreeDSPaymentRequest, path, RequestOptions),
                initThreeDSPaymentRequest);
        }

        public Task<InitThreeDSPaymentResponse> Init3DSPaymentAsync(InitThreeDSPaymentRequest initThreeDSPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-init";
            return AsyncRestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
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

        public Task<PaymentResponse> Complete3DSPaymentAsync(CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-complete";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public PaymentResponse PostAuthPayment(long paymentId, PostAuthPaymentRequest postAuthPaymentRequest)
        {
            var path = "/payment/v1/card-payments/" + paymentId + "/post-auth";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(postAuthPaymentRequest, path, RequestOptions), postAuthPaymentRequest);
        }

        public Task<PaymentResponse> PostAuthPaymentAsync(long paymentId, PostAuthPaymentRequest postAuthPaymentRequest)
        {
            var path = "/payment/v1/card-payments/" + paymentId + "/post-auth";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(postAuthPaymentRequest, path, RequestOptions), postAuthPaymentRequest);
        }

        public InitCheckoutPaymentResponse InitCheckoutPayment(InitCheckoutPaymentRequest initCheckoutPaymentRequest)
        {
            var path = "/payment/v1/checkout-payments/init";
            return RestClient.Post<InitCheckoutPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initCheckoutPaymentRequest, path, RequestOptions),
                initCheckoutPaymentRequest);
        }

        public Task<InitCheckoutPaymentResponse> InitCheckoutPaymentAsync(InitCheckoutPaymentRequest initCheckoutPaymentRequest)
        {
            var path = "/payment/v1/checkout-payments/init";
            return AsyncRestClient.Post<InitCheckoutPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initCheckoutPaymentRequest, path, RequestOptions),
                initCheckoutPaymentRequest);
        }

        public PaymentResponse RetrieveCheckoutPayment(string token)
        {
            var path = "/payment/v1/checkout-payments/" + token;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PaymentResponse> RetrieveCheckoutPaymentAsync(string token)
        {
            var path = "/payment/v1/checkout-payments/" + token;
            return AsyncRestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public DepositPaymentResponse CreateDepositPayment(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public Task<DepositPaymentResponse> CreateDepositPaymentAsync(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits";
            return AsyncRestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public InitThreeDSPaymentResponse Init3DSDepositPayment(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-init";
            return RestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public Task<InitThreeDSPaymentResponse> Init3DSDepositPaymentAsync(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-init";
            return AsyncRestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public DepositPaymentResponse Complete3DSDepositPayment(CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-complete";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public Task<DepositPaymentResponse> Complete3DSDepositPaymentAsync(CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-complete";
            return AsyncRestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public void CreateFundTransferDepositPayment(CreateFundTransferDepositPaymentRequest createFundTransferDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/fund-transfer";
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(createFundTransferDepositPaymentRequest, path, RequestOptions),
                createFundTransferDepositPaymentRequest);
        }

        public void CreateFundTransferDepositPaymentAsync(CreateFundTransferDepositPaymentRequest createFundTransferDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/fund-transfer";
            AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(createFundTransferDepositPaymentRequest, path, RequestOptions),
                createFundTransferDepositPaymentRequest);
        }

        public InitGarantiPayPaymentResponse InitGarantiPayPayment(InitGarantiPayPaymentRequest initGarantiPayPaymentRequest)
        {
            var path = "/payment/v1/garanti-pay-payments";
            return RestClient.Post<InitGarantiPayPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initGarantiPayPaymentRequest, path, RequestOptions),
                initGarantiPayPaymentRequest);
        }

        public Task<InitGarantiPayPaymentResponse> InitGarantiPayPaymentAsync(InitGarantiPayPaymentRequest initGarantiPayPaymentRequest)
        {
            var path = "/payment/v1/garanti-pay-payments";
            return AsyncRestClient.Post<InitGarantiPayPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initGarantiPayPaymentRequest, path, RequestOptions),
                initGarantiPayPaymentRequest);
        }

        public InitApmPaymentResponse InitApmPayment(InitApmPaymentRequest initApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments/init";
            return RestClient.Post<InitApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initApmPaymentRequest, path, RequestOptions),
                initApmPaymentRequest);
        }

        public Task<InitApmPaymentResponse> InitApmPaymentAsync(InitApmPaymentRequest initApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments/init";
            return AsyncRestClient.Post<InitApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initApmPaymentRequest, path, RequestOptions),
                initApmPaymentRequest);
        }

        public CompleteApmPaymentResponse CompleteApmPayment(CompleteApmPaymentRequest completeApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments/complete";
            return RestClient.Post<CompleteApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeApmPaymentRequest, path, RequestOptions),
                completeApmPaymentRequest);
        }

        public Task<CompleteApmPaymentResponse> CompleteApmPaymentAsync(CompleteApmPaymentRequest completeApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments/complete";
            return AsyncRestClient.Post<CompleteApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeApmPaymentRequest, path, RequestOptions),
                completeApmPaymentRequest);
        }

        public RetrieveLoyaltiesResponse RetrieveLoyalties(RetrieveLoyaltiesRequest retrieveLoyaltiesRequest)
        {
            var path = "/payment/v1/card-loyalties/retrieve";
            return RestClient.Post<RetrieveLoyaltiesResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(retrieveLoyaltiesRequest, path, RequestOptions),
                retrieveLoyaltiesRequest);
        }

        public Task<RetrieveLoyaltiesResponse> RetrieveLoyaltiesAsync(RetrieveLoyaltiesRequest retrieveLoyaltiesRequest)
        {
            var path = "/payment/v1/card-loyalties/retrieve";
            return AsyncRestClient.Post<RetrieveLoyaltiesResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(retrieveLoyaltiesRequest, path, RequestOptions),
                retrieveLoyaltiesRequest);
        }

        public PaymentTransactionRefundResponse RefundPaymentTransaction(RefundPaymentTransactionRequest refundPaymentTransactionRequest)
        {
            var path = "/payment/v1/refund-transactions";
            return RestClient.Post<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentTransactionRequest, path, RequestOptions),
                refundPaymentTransactionRequest);
        }

        public Task<PaymentTransactionRefundResponse> RefundPaymentTransactionAsync(RefundPaymentTransactionRequest refundPaymentTransactionRequest)
        {
            var path = "/payment/v1/refund-transactions";
            return AsyncRestClient.Post<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentTransactionRequest, path, RequestOptions),
                refundPaymentTransactionRequest);
        }

        public PaymentTransactionRefundResponse RetrievePaymentTransactionRefund(long id)
        {
            var path = "/payment/v1/refund-transactions/" + id;
            return RestClient.Get<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PaymentTransactionRefundResponse> RetrievePaymentTransactionRefundAsync(long id)
        {
            var path = "/payment/v1/refund-transactions/" + id;
            return AsyncRestClient.Get<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentRefundResponse RefundPayment(RefundPaymentRequest refundPaymentRequest)
        {
            var path = "/payment/v1/refunds";
            return RestClient.Post<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentRequest, path, RequestOptions),
                refundPaymentRequest);
        }

        public Task<PaymentRefundResponse> RefundPaymentAsync(RefundPaymentRequest refundPaymentRequest)
        {
            var path = "/payment/v1/refunds";
            return AsyncRestClient.Post<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentRequest, path, RequestOptions),
                refundPaymentRequest);
        }

        public PaymentRefundResponse RetrievePaymentRefund(long id)
        {
            var path = "/payment/v1/refunds/" + id;
            return RestClient.Get<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<PaymentRefundResponse> RetrievePaymentRefundAsync(long id)
        {
            var path = "/payment/v1/refunds/" + id;
            return AsyncRestClient.Get<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public StoredCardResponse StoreCard(StoreCardRequest storeCardRequest)
        {
            var path = "/payment/v1/cards";
            return RestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(storeCardRequest, path, RequestOptions), storeCardRequest);
        }

        public Task<StoredCardResponse> StoreCardAsync(StoreCardRequest storeCardRequest)
        {
            var path = "/payment/v1/cards";
            return AsyncRestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(storeCardRequest, path, RequestOptions), storeCardRequest);
        }

        public StoredCardResponse UpdateCard(UpdateCardRequest updateCardRequest)
        {
            var path = "/payment/v1/cards/update";
            return RestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateCardRequest, path, RequestOptions), updateCardRequest);
        }

        public Task<StoredCardResponse> UpdateCardAsync(UpdateCardRequest updateCardRequest)
        {
            var path = "/payment/v1/cards/update";
            return AsyncRestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateCardRequest, path, RequestOptions), updateCardRequest);
        }

        public StoredCardListResponse SearchStoredCards(SearchStoredCardsRequest searchStoredCardsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchStoredCardsRequest);
            var path = "/payment/v1/cards" + query;

            return RestClient.Get<StoredCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<StoredCardListResponse> SearchStoredCardsAsync(SearchStoredCardsRequest searchStoredCardsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchStoredCardsRequest);
            var path = "/payment/v1/cards" + query;

            return AsyncRestClient.Get<StoredCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteStoredCard(DeleteStoredCardRequest deleteStoredCardRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(deleteStoredCardRequest);
            var path = "/payment/v1/cards" + query;

            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task DeleteStoredCardAsync(DeleteStoredCardRequest deleteStoredCardRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(deleteStoredCardRequest);
            var path = "/payment/v1/cards" + query;

            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionApprovalListResponse ApprovePaymentTransactions(ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public Task<PaymentTransactionApprovalListResponse> ApprovePaymentTransactionsAsync(ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public PaymentTransactionApprovalListResponse DisapprovePaymentTransactions(DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/disapprove";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public Task<PaymentTransactionApprovalListResponse> DisapprovePaymentTransactionsAsync(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/disapprove";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public CheckMasterpassUserResponse CheckMasterpassUser(CheckMasterpassUserRequest checkMasterpassUserRequest)
        {
            var path = "/payment/v1/masterpass-payments/check-user";
            return RestClient.Post<CheckMasterpassUserResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(checkMasterpassUserRequest, path, RequestOptions), checkMasterpassUserRequest);
        }

        public Task<CheckMasterpassUserResponse> CheckMasterpassUserAsync(CheckMasterpassUserRequest checkMasterpassUserRequest)
        {
            var path = "/payment/v1/masterpass-payments/check-user";
            return AsyncRestClient.Post<CheckMasterpassUserResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(checkMasterpassUserRequest, path, RequestOptions), checkMasterpassUserRequest);
        }


        public PaymentTransactionResponse UpdatePaymentTransaction(UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/payment/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return RestClient.Put<PaymentTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }

        public Task<PaymentTransactionResponse> UpdatePaymentTransactionAsync(UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/payment/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return AsyncRestClient.Put<PaymentTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }
    }
}