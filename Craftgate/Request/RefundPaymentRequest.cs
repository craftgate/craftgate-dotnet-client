using Craftgate.Model;

namespace Craftgate.Request
{
    public class RefundPaymentRequest
    {
        public long? PaymentId { get; set; }
        public string ConversationId { get; set; }
        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.CARD;
        public bool? ChargeFromMe { get; set; } = false;
    }
}