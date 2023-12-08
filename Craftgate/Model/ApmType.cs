using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApmType
    {
        [EnumMember(Value = "PAPARA")] PAPARA,
        [EnumMember(Value = "PAYONEER")] PAYONEER,
        [EnumMember(Value = "SODEXO")] SODEXO,
        [EnumMember(Value = "EDENRED")] EDENRED,
        [EnumMember(Value = "EDENRED_GIFT")] EDENRED_GIFT,
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "KLARNA")] KLARNA,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "KASPI")] KASPI,
        [EnumMember(Value = "TOMPAY")] TOMPAY,
        [EnumMember(Value = "MASLAK")] MASLAK,
        [EnumMember(Value = "ALFABANK")] ALFABANK,
        [EnumMember(Value = "TOM_FINANCE")] TOM_FINANCE,
        [EnumMember(Value = "PAYCELL")] PAYCELL,
        [EnumMember(Value = "FUND_TRANSFER")] FUND_TRANSFER,
        [EnumMember(Value = "CASH_ON_DELIVERY")] CASH_ON_DELIVERY
    }
}