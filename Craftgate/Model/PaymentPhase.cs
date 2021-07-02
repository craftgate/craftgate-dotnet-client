using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentPhase
    {
        [EnumMember(Value = "AUTH")] AUTH,
        [EnumMember(Value = "PRE_AUTH")] PRE_AUTH,
        [EnumMember(Value = "POST_AUTH")] POST_AUTH
    }
}