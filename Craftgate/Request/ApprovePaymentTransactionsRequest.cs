using System.Collections.Generic;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class ApprovePaymentTransactionsRequest : BaseRequest
    {
        public ISet<long> PaymentTransactionIds { get; set; }
        public bool IsTransactional { get; set; } = false;
    }
}