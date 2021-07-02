using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardAssociation
    {
        [EnumMember(Value = "VISA")] VISA,

        [EnumMember(Value = "MASTER_CARD")] MASTER_CARD,

        [EnumMember(Value = "AMEX")] AMEX,

        [EnumMember(Value = "TROY")] TROY
    }
}