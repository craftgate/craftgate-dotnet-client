using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class BnplLimitInquiryRequest
    {
        public ApmType ApmType { get; set; }
        public long? MerchantApmId { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}