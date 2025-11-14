using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementType
    {
        [EnumMember(Value = "SETTLEMENT")] SETTLEMENT,

        [EnumMember(Value = "BOUNCED_SETTLEMENT")]
        BOUNCED_SETTLEMENT,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW
    }
}