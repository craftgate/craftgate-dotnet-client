using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementSource
    {
        [EnumMember(Value = "COLLECTION")] COLLECTION,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW,
        [EnumMember(Value = "BOUNCED")] BOUNCED,
        [EnumMember(Value = "MONEY_TRANSFER")] MONEY_TRANSFER
    }
}