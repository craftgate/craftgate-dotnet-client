using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPaymentTransactionRefundsRequest
    {
        public long? PaymentId { get; set; }
        public string ConversationId { get; set; }
        public long? PaymentTransactionId { get; set; }
    }
}