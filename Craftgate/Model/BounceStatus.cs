using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum BounceStatus
    {
        [EnumMember(Value = "NOT_BOUNCED")] NOT_BOUNCED,

        [EnumMember(Value = "BOUNCED")] BOUNCED,
        
        [EnumMember(Value = "UPDATED")] UPDATED,
        
        [EnumMember(Value = "PAYOUT_STARTED")] PAYOUT_STARTED,
        
        [EnumMember(Value = "PAYOUT_COMPLETED")] PAYOUT_COMPLETED
    }
}
