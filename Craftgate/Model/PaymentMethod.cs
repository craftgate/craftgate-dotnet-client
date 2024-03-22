using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentMethod
    {
        [EnumMember(Value = "MASTERPASS")] MASTERPASS,
        [EnumMember(Value = "CARD")] CARD,
        [EnumMember(Value = "PAPARA")] PAPARA,
        [EnumMember(Value = "PAYONEER")] PAYONEER,
        [EnumMember(Value = "SODEXO")] SODEXO,
        [EnumMember(Value = "EDENRED")] EDENRED,
        [EnumMember(Value = "EDENRED_GIFT")] EDENRED_GIFT,
        [EnumMember(Value = "ALIPAY")] ALIPAY,
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "KLARNA")] KLARNA,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "KASPI")] KASPI,
        [EnumMember(Value = "INSTANT_TRANSFER")] INSTANT_TRANSFER,
        [EnumMember(Value = "TOMPAY")] TOMPAY
    }
}