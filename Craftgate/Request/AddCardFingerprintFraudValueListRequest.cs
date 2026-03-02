using Craftgate.Model;

namespace Craftgate.Request
{
    public class AddCardFingerprintFraudValueListRequest
    {
        public string Label { get; set; }
        public FraudOperation Operation { get; set; }
        public string OperationId { get; set; }
        public int? DurationInSeconds { get; set; }
    }
}