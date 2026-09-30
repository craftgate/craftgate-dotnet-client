using System;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchFraudRuleRequest : BaseRequest
    {
        public int? Page { get; set; }
        public int? Size { get; set; }
        public string Name { get; set; }
        public FraudAction? Action { get; set; }
        public FraudOperation? Operation { get; set; }
        public FraudRuleScope? Scope { get; set; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
    }
}