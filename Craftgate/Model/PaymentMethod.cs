using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentMethod
    {
        [EnumMember(Value = "CARD")] CARD,
        [EnumMember(Value = "MASTERPASS")] MASTERPASS,
        [EnumMember(Value = "PAPARA")] PAPARA,
        [EnumMember(Value = "PAYONEER")] PAYONEER,
        [EnumMember(Value = "SODEXO")] SODEXO,
        [EnumMember(Value = "SODEXO_GIFT")] SODEXO_GIFT,
        [EnumMember(Value = "EDENRED")] EDENRED,
        [EnumMember(Value = "EDENRED_GIFT")] EDENRED_GIFT,
        [EnumMember(Value = "TOKENFLEX")] TOKENFLEX,
        [EnumMember(Value = "TOKENFLEX_GIFT")] TOKENFLEX_GIFT,
        [EnumMember(Value = "ALIPAY")] ALIPAY,
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "KLARNA")] KLARNA,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "INSTANT_TRANSFER")] INSTANT_TRANSFER,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "HEPSIPAY")] HEPSIPAY,
        [EnumMember(Value = "GARANTI_PAY")] GARANTI_PAY,
        [EnumMember(Value = "JUZDAN")] JUZDAN,
        [EnumMember(Value = "YKB_WORLD_PAY")] YKB_WORLD_PAY,
        [EnumMember(Value = "YKB_WORLD_PAY_SHOPPING_LOAN")] YKB_WORLD_PAY_SHOPPING_LOAN,
        [EnumMember(Value = "MULTINET")] MULTINET,
        [EnumMember(Value = "MULTINET_GIFT")] MULTINET_GIFT,
        [EnumMember(Value = "MULTINET_NEO_GIFT")] MULTINET_NEO_GIFT,
        [EnumMember(Value = "METROPOL")] METROPOL,
        [EnumMember(Value = "ISPAY")] ISPAY,
        [EnumMember(Value = "PAYMOB")] PAYMOB,
        [EnumMember(Value = "VODAFONE_DCB")] VODAFONE_DCB,
        [EnumMember(Value = "KASPI")] KASPI,
        [EnumMember(Value = "BIZUM")] BIZUM,
        [EnumMember(Value = "PAYLANDS_MB_WAY")] PAYLANDS_MB_WAY,
        [EnumMember(Value = "ZIP")] ZIP,
        [EnumMember(Value = "KARACA_FINANS")] KARACA_FINANS,
        [EnumMember(Value = "PAYCELL_DCB")] PAYCELL_DCB,
        [EnumMember(Value = "SETCARD")] SETCARD,
        [EnumMember(Value = "IWALLET")] IWALLET,
        [EnumMember(Value = "PAPEL")] PAPEL,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS
    }
}