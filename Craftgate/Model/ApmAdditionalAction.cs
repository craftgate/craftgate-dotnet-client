using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ApmAdditionalAction
    {
        [EnumMember(Value = "REDIRECT_TO_URL")] REDIRECT_TO_URL,
        [EnumMember(Value = "OTP_REQUIRED")] OTP_REQUIRED,
        [EnumMember(Value = "SHOW_HTML_CONTENT")] SHOW_HTML_CONTENT,
        [EnumMember(Value = "WAIT_FOR_WEBHOOK")] WAIT_FOR_WEBHOOK,
        [EnumMember(Value = "APPROVAL_REQUIRED")] APPROVAL_REQUIRED,
        [EnumMember(Value = "VERIFY_REQUIRED")] VERIFY_REQUIRED,
        [EnumMember(Value = "SHOW_QR_CODE")] SHOW_QR_CODE,
        [EnumMember(Value = "NONE")] NONE
    }
}