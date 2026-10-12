using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class PostAuthPaymentRequest : BaseRequest
    {
        public decimal? PaidPrice { get; set; }
    }
}