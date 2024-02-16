using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentProvider
    {
        [EnumMember(Value = "BANK")] BANK,
        [EnumMember(Value = "CG_WALLET")] CG_WALLET,
        [EnumMember(Value = "MASTERPASS")] MASTERPASS,
        [EnumMember(Value = "GARANTI_PAY")] GARANTI_PAY,
        [EnumMember(Value = "PAPARA")] PAPARA,
        [EnumMember(Value = "PAYONEER")] PAYONEER,
        [EnumMember(Value = "SODEXO")] SODEXO,
        [EnumMember(Value = "EDENRED")] EDENRED,
        [EnumMember(Value = "YKB_WORLD_PAY")] YKB_WORLD_PAY,
        [EnumMember(Value = "APPLEPAY")] APPLEPAY,
        [EnumMember(Value = "GOOGLEPAY")] GOOGLEPAY,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "KASPI")] KASPI,
        [EnumMember(Value = "TOMPAY")] TOMPAY,
        [EnumMember(Value = "ALIPAY")] ALIPAY,
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "KLARNA")] KLARNA,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "HEPSIPAY")] HEPSIPAY,
        [EnumMember(Value = "MASLAK")] MASLAK,
        [EnumMember(Value = "TOM_FINANCE")] TOM_FINANCE,
        [EnumMember(Value = "ALFABANK")] ALFABANK,
        [EnumMember(Value = "PAYCELL")] PAYCELL,
        [EnumMember(Value = "HASO")] HASO,
        [EnumMember(Value = "OFFLINE")] OFFLINE
    }
}