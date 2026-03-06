using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitBnplLimitInquiryRequest
    {
        public ApmType ApmType { get; set; }
        public long? MerchantApmId { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}