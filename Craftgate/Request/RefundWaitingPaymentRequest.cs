using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RefundWaitingPaymentRequest : BaseRequest
    {
        public long? PaymentId { get; set; }
    }
}