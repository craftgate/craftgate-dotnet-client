using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class ExpireCheckoutPaymentRequest : BaseRequest
    {
        public string Token { get; set; }
    }
}
