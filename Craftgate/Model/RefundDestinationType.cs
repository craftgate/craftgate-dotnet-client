using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundDestinationType
    {
        [EnumMember(Value = "CARD")] CARD,
        [EnumMember(Value = "WALLET")] WALLET
    }
}