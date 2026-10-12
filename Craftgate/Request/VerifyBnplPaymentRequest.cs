using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class VerifyBnplPaymentRequest : BaseRequest
    {
        public long? PaymentId { get; set; }
    }
}
