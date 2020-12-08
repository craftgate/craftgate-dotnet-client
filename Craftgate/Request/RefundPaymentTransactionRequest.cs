using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RefundPaymentTransactionRequest
    {
        public long? PaymentTransactionId { get; set; }

        public string ConversationId { get; set; }

        public decimal? RefundPrice { get; set; }

        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.Card;
    }
}