using Craftgate.Model;

namespace Craftgate.Request
{
    public class RefundPaymentTransactionRequest
    {
        public long? PaymentTransactionId { get; set; }
        public string ConversationId { get; set; }
        public decimal? RefundPrice { get; set; }
        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.CARD;
        public bool? ChargeFromMe { get; set; } = false;
    }
}