using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchFraudChecksRequest
    {
        public FraudAction? Action { get; set; }
        public FraudCheckStatus? CheckStatus { get; set; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
        public long? RuleId { get; set; }
        public long? PaymentId { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }
    }
}