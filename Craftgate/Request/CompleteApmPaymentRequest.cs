using System.Collections.Generic;

namespace Craftgate.Request
{
    public class CompleteApmPaymentRequest
    {
        public long PaymentId { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}