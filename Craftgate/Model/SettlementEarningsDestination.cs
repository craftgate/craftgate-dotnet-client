using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementEarningsDestination
    {
        [EnumMember(Value = "IBAN")] IBAN,
        [EnumMember(Value = "WALLET")] WALLET,
        [EnumMember(Value = "CROSS_BORDER")] CROSS_BORDER
    }
}