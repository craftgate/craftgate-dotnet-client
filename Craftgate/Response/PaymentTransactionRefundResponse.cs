using Craftgate.Model;
using Craftgate.Response.Common;

namespace Craftgate.Response
{
    public class PaymentTransactionRefundResponse : BasePaymentTransactionRefundResponse
    {
        public Currency Currency { get; set; }
        public long? PaymentId { get; set; }
    }
}