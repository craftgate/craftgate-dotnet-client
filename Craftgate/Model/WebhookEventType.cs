using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WebhookEventType
    {
        [EnumMember(Value = "API_AUTH")] API_AUTH,
        [EnumMember(Value = "API_VERIFY_AND_AUTH")] API_VERIFY_AND_AUTH,
        [EnumMember(Value = "CHECKOUTFORM_AUTH")] CHECKOUTFORM_AUTH,
        [EnumMember(Value = "THREEDS_VERIFY")] THREEDS_VERIFY
    }
}