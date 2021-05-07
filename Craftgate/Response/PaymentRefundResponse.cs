using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Common;

namespace Craftgate.Response
{
    public class PaymentRefundResponse : BasePaymentRefundResponse
    {
        public RefundType? RefundType { get; set; }
        public Currency Currency { get; set; }
        public IList<PaymentTransactionRefundResponse> PaymentTransactionRefunds { get; set; }
    }
}