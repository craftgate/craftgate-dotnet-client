using System;
using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundDestinationType
    {
        [Obsolete("deprecated since version 1.0.26. use PROVIDER instead.")] [EnumMember(Value = "CARD")]
        CARD,
        [EnumMember(Value = "PROVIDER")] PROVIDER,
        [EnumMember(Value = "WALLET")] WALLET
    }
}