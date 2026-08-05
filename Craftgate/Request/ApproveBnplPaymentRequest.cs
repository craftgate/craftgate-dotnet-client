using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class ApproveBnplPaymentRequest : BaseRequest
    {
        public long? PaymentId { get; set; }
    }
}
