using System.Collections.Generic;
using System.Text;
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

        public Task<PaymentResponse> Complete3DSPaymentAsync(
            CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
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

        public Task<InitCheckoutPaymentResponse> InitCheckoutPaymentAsync(
            InitCheckoutPaymentRequest initCheckoutPaymentRequest)
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

        public void ExpireCheckoutPayment(string token)
        {
            var path = "/payment/v1/checkout-payments/" + token;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task ExpireCheckoutPaymentAsync(string token)
        {
            var path = "/payment/v1/checkout-payments/" + token;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public DepositPaymentResponse CreateDepositPayment(CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public Task<DepositPaymentResponse> CreateDepositPaymentAsync(
            CreateDepositPaymentRequest createDepositPaymentRequest)
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

        public Task<InitThreeDSPaymentResponse> Init3DSDepositPaymentAsync(
            CreateDepositPaymentRequest createDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-init";
            return AsyncRestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createDepositPaymentRequest, path, RequestOptions),
                createDepositPaymentRequest);
        }

        public DepositPaymentResponse Complete3DSDepositPayment(
            CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-complete";
            return RestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public Task<DepositPaymentResponse> Complete3DSDepositPaymentAsync(
            CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/deposits/3ds-complete";
            return AsyncRestClient.Post<DepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public FundTransferDepositPaymentResponse CreateFundTransferDepositPayment(
            CreateFundTransferDepositPaymentRequest createFundTransferDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/fund-transfer";
            return RestClient.Post<FundTransferDepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createFundTransferDepositPaymentRequest, path, RequestOptions),
                createFundTransferDepositPaymentRequest);
        }

        public Task<FundTransferDepositPaymentResponse> CreateFundTransferDepositPaymentAsync(
            CreateFundTransferDepositPaymentRequest createFundTransferDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/fund-transfer";
            return AsyncRestClient.Post<FundTransferDepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createFundTransferDepositPaymentRequest, path, RequestOptions),
                createFundTransferDepositPaymentRequest);
        }

        public ApmDepositPaymentResponse InitApmDepositPayment(
            InitApmDepositPaymentRequest initApmDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/apm-init";
            return RestClient.Post<ApmDepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initApmDepositPaymentRequest, path, RequestOptions),
                initApmDepositPaymentRequest);
        }

        public Task<ApmDepositPaymentResponse> InitApmDepositPaymentAsync(
            InitApmDepositPaymentRequest initApmDepositPaymentRequest)
        {
            var path = "/payment/v1/deposits/apm-init";
            return AsyncRestClient.Post<ApmDepositPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initApmDepositPaymentRequest, path, RequestOptions),
                initApmDepositPaymentRequest);
        }

        public InitGarantiPayPaymentResponse InitGarantiPayPayment(
            InitGarantiPayPaymentRequest initGarantiPayPaymentRequest)
        {
            var path = "/payment/v1/garanti-pay-payments";
            return RestClient.Post<InitGarantiPayPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initGarantiPayPaymentRequest, path, RequestOptions),
                initGarantiPayPaymentRequest);
        }

        public Task<InitGarantiPayPaymentResponse> InitGarantiPayPaymentAsync(
            InitGarantiPayPaymentRequest initGarantiPayPaymentRequest)
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

        public Task<CompleteApmPaymentResponse> CompleteApmPaymentAsync(
            CompleteApmPaymentRequest completeApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments/complete";
            return AsyncRestClient.Post<CompleteApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeApmPaymentRequest, path, RequestOptions),
                completeApmPaymentRequest);
        }

        public PaymentResponse CreateApmPayment(CreateApmPaymentRequest createApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createApmPaymentRequest, path, RequestOptions),
                createApmPaymentRequest);
        }

        public Task<PaymentResponse> CreateApmPaymentAsync(CreateApmPaymentRequest createApmPaymentRequest)
        {
            var path = "/payment/v1/apm-payments";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createApmPaymentRequest, path, RequestOptions),
                createApmPaymentRequest);
        }

        public InitPosApmPaymentResponse InitPosApmPayment(InitPosApmPaymentRequest initPosApmPaymentRequest)
        {
            var path = "/payment/v1/pos-apm-payments/init";
            return RestClient.Post<InitPosApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initPosApmPaymentRequest, path, RequestOptions),
                initPosApmPaymentRequest);
        }

        public Task<InitPosApmPaymentResponse> InitPosApmPaymentAsync(InitPosApmPaymentRequest initPosApmPaymentRequest)
        {
            var path = "/payment/v1/pos-apm-payments/init";
            return AsyncRestClient.Post<InitPosApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initPosApmPaymentRequest, path, RequestOptions),
                initPosApmPaymentRequest);
        }

        public CompletePosApmPaymentResponse CompletePosApmPayment(
            CompletePosApmPaymentRequest completePosApmPaymentRequest)
        {
            var path = "/payment/v1/pos-apm-payments/complete";
            return RestClient.Post<CompletePosApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completePosApmPaymentRequest, path, RequestOptions),
                completePosApmPaymentRequest);
        }

        public Task<CompletePosApmPaymentResponse> CompletePosApmPaymentAsync(
            CompletePosApmPaymentRequest completePosApmPaymentRequest)
        {
            var path = "/payment/v1/pos-apm-payments/complete";
            return AsyncRestClient.Post<CompletePosApmPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completePosApmPaymentRequest, path, RequestOptions),
                completePosApmPaymentRequest);
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

        public PaymentTransactionRefundResponse RefundPaymentTransaction(
            RefundPaymentTransactionRequest refundPaymentTransactionRequest)
        {
            var path = "/payment/v1/refund-transactions";
            return RestClient.Post<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentTransactionRequest, path, RequestOptions),
                refundPaymentTransactionRequest);
        }

        public Task<PaymentTransactionRefundResponse> RefundPaymentTransactionAsync(
            RefundPaymentTransactionRequest refundPaymentTransactionRequest)
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
        
        public StoredCardResponse CloneCard(CloneCardRequest cloneCardRequest)
        {
            var path = "/payment/v1/cards/clone";
            return RestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(cloneCardRequest, path, RequestOptions), cloneCardRequest);
        }

        public Task<StoredCardResponse> CloneCardAsync(CloneCardRequest cloneCardRequest)
        {
            var path = "/payment/v1/cards/clone";
            return AsyncRestClient.Post<StoredCardResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(cloneCardRequest, path, RequestOptions), cloneCardRequest);
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
            var path = "/payment/v1/cards/delete";
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(deleteStoredCardRequest, path, RequestOptions), deleteStoredCardRequest);
        }

        public Task DeleteStoredCardAsync(DeleteStoredCardRequest deleteStoredCardRequest)
        {
            var path = "/payment/v1/cards/delete";
            return AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(deleteStoredCardRequest, path, RequestOptions), deleteStoredCardRequest);
        }

        public PaymentTransactionApprovalListResponse ApprovePaymentTransactions(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public Task<PaymentTransactionApprovalListResponse> ApprovePaymentTransactionsAsync(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
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

        public Task<PaymentTransactionApprovalListResponse> DisapprovePaymentTransactionsAsync(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/disapprove";
            return AsyncRestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public PaymentTransactionResponse UpdatePaymentTransaction(
            UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/payment/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return RestClient.Put<PaymentTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }

        public Task<PaymentTransactionResponse> UpdatePaymentTransactionAsync(
            UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/payment/v1/payment-transactions/" + updatePaymentTransactionRequest.PaymentTransactionId;
            return AsyncRestClient.Put<PaymentTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions), updatePaymentTransactionRequest);
        }

        public BnplPaymentOfferResponse RetrieveBnplOffers(BnplPaymentOfferRequest request)
        {
            var path = "/payment/v1/bnpl-payments/offers";
            return RestClient.Post<BnplPaymentOfferResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<BnplPaymentOfferResponse> RetrieveBnplOffersAsync(BnplPaymentOfferRequest request)
        {
            var path = "/payment/v1/bnpl-payments/offers";
            return AsyncRestClient.Post<BnplPaymentOfferResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public InitBnplPaymentResponse InitBnplPayment(InitBnplPaymentRequest request)
        {
            var path = "/payment/v1/bnpl-payments/init";
            return RestClient.Post<InitBnplPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task<InitBnplPaymentResponse> InitBnplPaymentAsync(InitBnplPaymentRequest request)
        {
            var path = "/payment/v1/bnpl-payments/init";
            return AsyncRestClient.Post<InitBnplPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public void ApproveBnplPayment(long PaymentId)
        {
            var path = "/payment/v1/bnpl-payments/" + PaymentId + "/approve";
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(null, path, RequestOptions), null);
        }

        public Task ApproveBnplPaymentAsync(long PaymentId)
        {
            var path = "/payment/v1/bnpl-payments/" + PaymentId + "/approve";
            return AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(null, path, RequestOptions), null);
        }

        public InstantTransferBanksResponse RetrieveActiveBanks()
        {
            var path = "/payment/v1/instant-transfer-banks";
            return RestClient.Get<InstantTransferBanksResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<InstantTransferBanksResponse> RetrieveActiveBanksAsync()
        {
            var path = "/payment/v1/instant-transfer-banks";
            return AsyncRestClient.Get<InstantTransferBanksResponse>(RequestOptions.BaseUrl + path,
            CreateHeaders(path, RequestOptions));
        }

        
        public object CreateApplePayMerchantSession(
            ApplePayMerchantSessionCreateRequest applePayMerchantSessionCreateRequest)
        {
            var path = "/payment/v1/apple-pay/merchant-sessions";
            return RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(applePayMerchantSessionCreateRequest, path, RequestOptions), applePayMerchantSessionCreateRequest);
        }

        public Task<object> CreateApplePayMerchantSessionAsync(
            ApplePayMerchantSessionCreateRequest applePayMerchantSessionCreateRequest)
        {
            var path = "/payment/v1/apple-pay/merchant-sessions";
            return AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(applePayMerchantSessionCreateRequest, path, RequestOptions), applePayMerchantSessionCreateRequest);
        }
        
        public bool Is3DSecureCallbackVerified(string threeDSecureCallbackKey, Dictionary<string, string> parameters)
        {
            string hash = parameters["hash"];
            string hashString = new StringBuilder(threeDSecureCallbackKey)
                .Append("###")
                .Append(extractValue("status", parameters))
                .Append("###")
                .Append(extractValue("completeStatus", parameters))
                .Append("###")
                .Append(extractValue("paymentId", parameters))
                .Append("###")
                .Append(extractValue("conversationData", parameters))
                .Append("###")
                .Append(extractValue("conversationId", parameters))
                .Append("###")
                .Append(extractValue("callbackStatus", parameters))
                .ToString();

            string hashed = HashGenerator.GenerateHash(hashString);
            return hash.Equals(hashed);
        }

        private string extractValue(string key, Dictionary<string, string> parameters)
        {
            string value = parameters.TryGetValue(key, out value) ? value : "";
            return value;
        }
    }
}