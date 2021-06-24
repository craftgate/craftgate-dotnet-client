using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentPhase
    {
        [EnumMember(Value = "AUTH")] Auth,
        [EnumMember(Value = "PRE_AUTH")] PreAuth,
        [EnumMember(Value = "POST_AUTH")] PostAuth
    }
}