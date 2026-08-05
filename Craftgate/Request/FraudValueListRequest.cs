using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class FraudValueListRequest : BaseRequest
    {
        public string ListName { get; set; }
        public FraudValueType Type { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? DurationInSeconds { get; set; }
        public long? PaymentId { get; set; }
    }
}