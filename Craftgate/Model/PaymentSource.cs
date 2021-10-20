using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentSource
    {
        [EnumMember(Value = "API")] API,

        [EnumMember(Value = "MASTERPASS")] MASTERPASS,

        [EnumMember(Value = "CHECKOUT_FORM")] CHECKOUT_FORM
    }
}