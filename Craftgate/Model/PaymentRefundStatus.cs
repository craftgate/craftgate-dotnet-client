using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentRefundStatus
    {
        [EnumMember(Value = "NO_REFUND")] NoRefund,
        [EnumMember(Value = "NOT_REFUNDED")] NotRefunded,

        [EnumMember(Value = "PARTIAL_REFUNDED")]
        PartialRefunded,
        [EnumMember(Value = "FULLY_REFUNDED")] FullyRefunded
    }
}