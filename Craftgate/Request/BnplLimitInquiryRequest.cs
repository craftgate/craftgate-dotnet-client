using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class BnplLimitInquiryRequest : BaseRequest
    {
        public ApmType ApmType { get; set; }
        public long? MerchantApmId { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}