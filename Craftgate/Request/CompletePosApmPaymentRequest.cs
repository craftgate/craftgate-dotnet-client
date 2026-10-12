using System.Collections.Generic;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CompletePosApmPaymentRequest : BaseRequest
    {
        public long PaymentId { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}