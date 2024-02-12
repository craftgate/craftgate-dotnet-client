using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class JuzdanPaymentAdapter : BaseAdapter
    {
        public JuzdanPaymentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public InitJuzdanPaymentResponse Init(InitJuzdanPaymentRequest initJuzdanPaymentRequest)
        {
           var path = "/payment/v1/juzdan-payments/init";
           return RestClient.Post<InitJuzdanPaymentResponse>(RequestOptions.BaseUrl + path,
               CreateHeaders(initJuzdanPaymentRequest, path, RequestOptions), initJuzdanPaymentRequest);
        }

        public PaymentResponse Retrieve(string referenceId)
        {
            var path = "/payment/v1/juzdan-payments/" + referenceId;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }
    }
}
