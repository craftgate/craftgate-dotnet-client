using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RefundPaymentRequest : BaseRequest
    {
        public long? PaymentId { get; set; }
        public string ConversationId { get; set; }
        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.PROVIDER;
        public bool? ChargeFromMe { get; set; } = false;
    }
}