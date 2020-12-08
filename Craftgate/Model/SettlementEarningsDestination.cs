using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementEarningsDestination
    {
        [EnumMember(Value = "IBAN")] Iban,
        [EnumMember(Value = "WALLET")] Wallet
    }
}