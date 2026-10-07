using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CompleteThreeDSPaymentRequest : BaseRequest
    {
        public long? PaymentId { get; set; }
    }
}