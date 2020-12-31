using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardAssociation
    {
        [EnumMember(Value = "VISA")] Visa,

        [EnumMember(Value = "MASTER_CARD")] MasterCard,

        [EnumMember(Value = "AMEX")] Amex,

        [EnumMember(Value = "TROY")] Troy
    }
}