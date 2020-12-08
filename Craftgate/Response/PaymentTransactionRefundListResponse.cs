using System.Collections.Generic;

namespace Craftgate.Response
{
    public class PaymentTransactionRefundListResponse
    {
        public long? Size{get;set;}
        public IList<PaymentTransactionRefundResponse> Items{get;set;}
    }
}