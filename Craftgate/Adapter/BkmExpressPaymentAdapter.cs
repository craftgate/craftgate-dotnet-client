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

        public BkmExpressGenerateTokenResponse GenerateToken(BkmExpressGenerateTokenRequest bkmExpressGenerateTokenRequest)
        {
            var path = "/payment/v2/bkm-express/generate-token";
            return RestClient.Post<BkmExpressGenerateTokenResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(bkmExpressGenerateTokenRequest, path, RequestOptions), bkmExpressGenerateTokenRequest);
        }
    }
}