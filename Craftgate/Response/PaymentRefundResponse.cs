using System.Collections.Generic;
using Craftgate.Response.Common;

namespace Craftgate.Response
{
    public class PaymentRefundResponse : BasePaymentRefundResponse
    {
        public string RefundType { get; set; }
        public string Currency { get; set; }
        public IList<PaymentTransactionRefundResponse> PaymentTransactionRefunds { get; set; }
    }
}