using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PayoutStatus
    {
        [EnumMember(Value = "CANCELLED")] Cancelled,

        [EnumMember(Value = "WAITING_FOR_PAYOUT")]
        WaitingForPayout,

        [EnumMember(Value = "PAYOUT_STARTED")] PayoutStarted,

        [EnumMember(Value = "PAYOUT_COMPLETED")]
        PayoutCompleted
    }
}