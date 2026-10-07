using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class AddCardFingerprintFraudValueListRequest : BaseRequest
    {
        public string Label { get; set; }
        public FraudOperation Operation { get; set; }
        public string OperationId { get; set; }
        public int? DurationInSeconds { get; set; }
    }
}