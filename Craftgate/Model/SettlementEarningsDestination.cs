using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementEarningsDestination
    {
        [EnumMember(Value = "IBAN")] IBAN,
        [EnumMember(Value = "WALLET")] WALLET
    }
}