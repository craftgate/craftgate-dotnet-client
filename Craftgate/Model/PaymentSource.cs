using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentSource
    {
        [EnumMember(Value = "API")] API,
        [EnumMember(Value = "CHECKOUT_FORM")] CHECKOUT_FORM,
        [EnumMember(Value = "PAY_BY_LINK")] PAY_BY_LINK,
        [EnumMember(Value = "JUZDAN")] JUZDAN,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS,
        [EnumMember(Value = "HEPSIPAY")] HEPSIPAY,
        [EnumMember(Value = "MONO")] MONO,
    }
}