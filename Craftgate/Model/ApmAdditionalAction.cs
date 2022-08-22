using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ApmAdditionalAction
    {
        [EnumMember(Value = "REDIRECT_TO_URL")] REDIRECT_TO_URL,
        [EnumMember(Value = "OTP_REQUIRED")] OTP_REQUIRED,
        [EnumMember(Value = "NONE")] NONE
    }
}