using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;


namespace Craftgate.Adapter
{
    public class MealVoucherCardTokenizationAdapter : BaseAdapter
    {
        public MealVoucherCardTokenizationAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public MealVoucherCardTokenizationInitResponse InitMealVoucherCardTokenization(MealVoucherCardTokenizationInitRequest request)
        {
            var path = "/payment/v1/meal-voucher/card-tokenizations/init";
            return RestClient.Post<MealVoucherCardTokenizationInitResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public MealVoucherCardTokenizationInitResponse RegenerateMealVoucherCardTokenization(string sessionId, MealVoucherCardTokenizationRegenerateRequest request)
        {
            var path = "/payment/v1/meal-voucher/card-tokenizations/" + sessionId + "/regenerate";
            return RestClient.Post<MealVoucherCardTokenizationInitResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public MealVoucherCardTokenizationCompleteResponse CompleteMealVoucherCardTokenization(string sessionId, MealVoucherCardTokenizationCompleteRequest request)
        {
            var path = "/payment/v1/meal-voucher/card-tokenizations/" + sessionId + "/complete";
            return RestClient.Post<MealVoucherCardTokenizationCompleteResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }
        
    }
}