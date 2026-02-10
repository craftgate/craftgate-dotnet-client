using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardVerificationAuthType
    {
        [EnumMember(Value = "NON_THREE_DS")] NON_THREE_DS,
        [EnumMember(Value = "THREE_DS")] THREE_DS,
        [EnumMember(Value = "NONE")] NONE
    }
}
