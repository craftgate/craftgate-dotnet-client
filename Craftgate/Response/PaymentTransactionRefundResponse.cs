using Craftgate.Response.Common;

namespace Craftgate.Response
{
    public class PaymentTransactionRefundResponse : BasePaymentTransactionRefundResponse
    {
        public string Currency { get; set; }
        public long? PaymentId { get; set; }
    }
}