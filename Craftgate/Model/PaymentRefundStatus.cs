using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentRefundStatus
    {
        [EnumMember(Value = "NO_REFUND")] NO_REFUND,
        [EnumMember(Value = "NOT_REFUNDED")] NOT_REFUNDED,

        [EnumMember(Value = "PARTIAL_REFUNDED")]
        PARTIAL_REFUNDED,
        [EnumMember(Value = "FULLY_REFUNDED")] FULLY_REFUNDED
    }
}