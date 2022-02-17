using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardAssociation
    {
        [EnumMember(Value = "VISA")] VISA,

        [EnumMember(Value = "MASTER_CARD")] MASTER_CARD,

        [EnumMember(Value = "AMEX")] AMEX,

        [EnumMember(Value = "TROY")] TROY,

        [EnumMember(Value = "JCB")] JCB,

        [EnumMember(Value = "UNION_PAY")] UNION_PAY,

        [EnumMember(Value = "MAESTRO")] MAESTRO,

        [EnumMember(Value = "DISCOVER")] DISCOVER,

        [EnumMember(Value = "DINERS_CLUB")] DINERS_CLUB
    }
}