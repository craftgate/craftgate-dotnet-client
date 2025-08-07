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
        [EnumMember(Value = "SETCARD")] SETCARD,
        [EnumMember(Value = "EDENRED_GIFT")] EDENRED_GIFT,
        [EnumMember(Value = "METROPOL")] METROPOL,
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "KLARNA")] KLARNA,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "ZIP")] ZIP,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "KASPI")] KASPI,
        [EnumMember(Value = "INSTANT_TRANSFER")] INSTANT_TRANSFER,
        [EnumMember(Value = "TOMPAY")] TOMPAY,
        [EnumMember(Value = "MASLAK")] MASLAK,
        [EnumMember(Value = "ALFABANK")] ALFABANK,
        [EnumMember(Value = "TOM_FINANCE")] TOM_FINANCE,
        [EnumMember(Value = "PAYCELL")] PAYCELL,
        [EnumMember(Value = "HASO")] HASO,
        [EnumMember(Value = "MULTINET")] MULTINET,
        [EnumMember(Value = "MULTINET_GIFT")] MULTINET_GIFT,
        [EnumMember(Value = "MULTINET_NEO_GIFT")] MULTINET_NEO_GIFT,
        [EnumMember(Value = "ISPAY")] ISPAY,
        [EnumMember(Value = "VODAFONE_DCB")] VODAFONE_DCB,
        [EnumMember(Value = "CHIPPIN")] CHIPPIN,
        [EnumMember(Value = "PAYMOB")] PAYMOB,
        [EnumMember(Value = "BIZUM")] BIZUM,
        [EnumMember(Value = "PAYLANDS_MB_WAY")] PAYLANDS_MB_WAY,
        [EnumMember(Value = "PAYCELL_DCB")] PAYCELL_DCB,
        [EnumMember(Value = "IWALLET")] IWALLET,
        [EnumMember(Value = "PAPEL")] PAPEL,
        [EnumMember(Value = "FUND_TRANSFER")] FUND_TRANSFER,
        [EnumMember(Value = "CASH_ON_DELIVERY")] CASH_ON_DELIVERY
    }
}