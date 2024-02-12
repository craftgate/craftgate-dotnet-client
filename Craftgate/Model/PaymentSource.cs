using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentSource
    {
        [EnumMember(Value = "API")] API,
        [EnumMember(Value = "CHECKOUT_FORM")] CHECKOUT_FORM,
        [EnumMember(Value = "PAY_BY_LINK")] PAY_BY_LINK,
        [EnumMember(Value = "JUZDAN")] JUZDAN
    }
}