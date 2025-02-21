using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class MasterpassPaymentAdapter : BaseAdapter
    {
        public MasterpassPaymentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public CheckMasterpassUserResponse CheckMasterpassUser(CheckMasterpassUserRequest checkMasterpassUserRequest)
        {
            var path = "/payment/v1/masterpass-payments/check-user";
            return RestClient.Post<CheckMasterpassUserResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(checkMasterpassUserRequest, path, RequestOptions), checkMasterpassUserRequest);
        }

        public Task<CheckMasterpassUserResponse> CheckMasterpassUserAsync(
            CheckMasterpassUserRequest checkMasterpassUserRequest)
        {
            var path = "/payment/v1/masterpass-payments/check-user";
            return AsyncRestClient.Post<CheckMasterpassUserResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(checkMasterpassUserRequest, path, RequestOptions), checkMasterpassUserRequest);
        }

        public MasterpassPaymentTokenGenerateResponse GenerateMasterpassPaymentToken(
            MasterpassPaymentTokenGenerateRequest masterpassPaymentTokenGenerateRequest)
        {
            var path = "/payment/v2/masterpass-payments/generate-token";
            return RestClient.Post<MasterpassPaymentTokenGenerateResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentTokenGenerateRequest, path, RequestOptions),
                masterpassPaymentTokenGenerateRequest);
        }

        public Task<MasterpassPaymentTokenGenerateResponse> GenerateMasterpassPaymentTokenAsync(
            MasterpassPaymentTokenGenerateRequest masterpassPaymentTokenGenerateRequest)
        {
            var path = "/payment/v2/masterpass-payments/generate-token";
            return AsyncRestClient.Post<MasterpassPaymentTokenGenerateResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentTokenGenerateRequest, path, RequestOptions),
                masterpassPaymentTokenGenerateRequest);
        }

        public PaymentResponse CompleteMasterpassPayment(
            MasterpassPaymentCompleteRequest masterpassPaymentCompleteRequest)
        {
            var path = "/payment/v2/masterpass-payments/complete";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentCompleteRequest, path, RequestOptions),
                masterpassPaymentCompleteRequest);
        }

        public Task<PaymentResponse> CompleteMasterpassPaymentAsync(
            MasterpassPaymentCompleteRequest masterpassPaymentCompleteRequest)
        {
            var path = "/payment/v2/masterpass-payments/complete";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentCompleteRequest, path, RequestOptions),
                masterpassPaymentCompleteRequest);
        }

        public MasterpassPaymentThreeDSInitResponse Init3DSMasterpassPayment(
            MasterpassPaymentThreeDSInitRequest masterpassPaymentThreeDSInitRequest)
        {
            var path = "/payment/v2/masterpass-payments/3ds-init";
            return RestClient.Post<MasterpassPaymentThreeDSInitResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentThreeDSInitRequest, path, RequestOptions),
                masterpassPaymentThreeDSInitRequest);
        }

        public Task<MasterpassPaymentThreeDSInitResponse> Init3DSMasterpassPaymentAsync(
            MasterpassPaymentThreeDSInitRequest masterpassPaymentThreeDSInitRequest)
        {
            var path = "/payment/v2/masterpass-payments/3ds-init";
            return AsyncRestClient.Post<MasterpassPaymentThreeDSInitResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentThreeDSInitRequest, path, RequestOptions),
                masterpassPaymentThreeDSInitRequest);
        }

        public PaymentResponse Complete3DSMasterpassPayment(
            MasterpassPaymentThreeDSCompleteRequest masterpassPaymentThreeDSCompleteRequest)
        {
            var path = "/payment/v2/masterpass-payments/3ds-complete";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentThreeDSCompleteRequest, path, RequestOptions),
                masterpassPaymentThreeDSCompleteRequest);
        }

        public Task<PaymentResponse> Complete3DSMasterpassPaymentAsync(
            MasterpassPaymentThreeDSCompleteRequest masterpassPaymentThreeDSCompleteRequest)
        {
            var path = "/payment/v2/masterpass-payments/3ds-complete";
            return AsyncRestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassPaymentThreeDSCompleteRequest, path, RequestOptions),
                masterpassPaymentThreeDSCompleteRequest);
        }
        
        public RetrieveLoyaltiesResponse RetrieveLoyalties(MasterpassRetrieveLoyaltiesRequest masterpassRetrieveLoyaltiesRequest)
        {
            var path = "/payment/v2/masterpass-payments/loyalties/retrieve";
            return RestClient.Post<RetrieveLoyaltiesResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassRetrieveLoyaltiesRequest, path, RequestOptions),
                masterpassRetrieveLoyaltiesRequest);
        }

        public Task<RetrieveLoyaltiesResponse> RetrieveLoyaltiesAsync(MasterpassRetrieveLoyaltiesRequest masterpassRetrieveLoyaltiesRequest)
        {
            var path = "/payment/v2/masterpass-payments/loyalties/retrieve";
            return AsyncRestClient.Post<RetrieveLoyaltiesResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(masterpassRetrieveLoyaltiesRequest, path, RequestOptions),
                masterpassRetrieveLoyaltiesRequest);
        }
    }
}