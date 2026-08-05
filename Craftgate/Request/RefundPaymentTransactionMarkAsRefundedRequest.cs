using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RefundPaymentTransactionMarkAsRefundedRequest : BaseRequest
    {
        public long? PaymentTransactionId { get; set; }
        public string ConversationId { get; set; }
        public decimal? RefundPrice { get; set; }
        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.PROVIDER;
        public bool? ChargeFromMe { get; set; } = false;
    }
}