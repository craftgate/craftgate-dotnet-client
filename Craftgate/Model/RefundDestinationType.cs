using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundDestinationType
    {
        [EnumMember(Value = "CARD")] Card,
        [EnumMember(Value = "WALLET")] Wallet
    }
}