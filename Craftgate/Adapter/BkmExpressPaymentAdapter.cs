using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class BkmExpressPaymentAdapter : BaseAdapter
    {
        public BkmExpressPaymentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public InitBkmExpressResponse Init(InitBkmExpressRequest initBkmExpressRequest)
        {
            var path = "/payment/v1/bkm-express/init";
            return RestClient.Post<InitBkmExpressResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initBkmExpressRequest, path, RequestOptions), initBkmExpressRequest);
        }

        public PaymentResponse Complete(
            CompleteBkmExpressRequest completeBkmExpressPayment)
        {
            var path = "/payment/v1/bkm-express/complete";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeBkmExpressPayment, path, RequestOptions),
                completeBkmExpressPayment);
        }

        public PaymentResponse RetrievePayment(
            string ticketId)
        {
            var path = "/payment/v1/bkm-express/payments/" + ticketId;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentResponse RetrievePaymentByToken(
            string token)
        {
            var path = "/payment/v1/bkm-express/" + token;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}