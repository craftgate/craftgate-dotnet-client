using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum TransactionStatus
    {
        [EnumMember(Value = "WAITING_FOR_APPROVAL")]
        WAITING_FOR_APPROVAL,
        [EnumMember(Value = "APPROVED")] APPROVED,
        [EnumMember(Value = "PAYOUT_STARTED")] PAYOUT_STARTED
    }
}