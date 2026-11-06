using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum TransactionPayoutStatus
    {
        [EnumMember(Value = "CANCELLED")] CANCELLED,

        [EnumMember(Value = "ELIMINATED_BY_FULLY_REFUND")]
        ELIMINATED_BY_FULLY_REFUND,

        [EnumMember(Value = "NO_PAYOUT")] NO_PAYOUT,

        [EnumMember(Value = "WAITING_FOR_PAYOUT")]
        WAITING_FOR_PAYOUT,

        [EnumMember(Value = "PAYOUT_STARTED")] PAYOUT_STARTED,

        [EnumMember(Value = "PAYOUT_COMPLETED")]
        PAYOUT_COMPLETED
    }
}