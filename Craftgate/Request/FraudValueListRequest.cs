using Craftgate.Model;

namespace Craftgate.Request
{
    public class FraudValueListRequest
    {
        public string ListName { get; set; }
        public FraudValueType Type { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? DurationInSeconds { get; set; }
        public long? PaymentId { get; set; }
    }
}