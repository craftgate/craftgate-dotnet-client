using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum TransactionPayoutStatus
    {
        [EnumMember(Value = "CANCELLED")] Cancelled,
        [EnumMember(Value = "NO_PAYOUT")] NoPayout,

        [EnumMember(Value = "WAITING_FOR_PAYOUT")]
        WaitingForPayout,

        [EnumMember(Value = "PAYOUT_STARTED")] PayoutStarted,

        [EnumMember(Value = "PAYOUT_COMPLETED")]
        PayoutCompleted
    }
}