using System.Collections.Generic;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPaymentTransactionPayoutsRequest : BaseRequest
    {
        public ISet<long> PaymentTransactionIds { get; set; }
    }
}