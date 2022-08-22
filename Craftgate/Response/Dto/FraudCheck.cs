using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class FraudCheck
    {
        public long Id { get; set; }
        public Status Status { get; set; }
        public FraudAction Action { get; set; }
        public FraudCheckStatus CheckStatus { get; set; }
        public FraudPaymentData PaymentData { get; set; }
        public long RuleId { get; set; }
        public string RuleName { get; set; }
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}