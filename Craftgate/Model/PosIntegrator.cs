using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PosIntegrator
    {
        [EnumMember(Value = "YKB")] YKB,
        [EnumMember(Value = "GARANTI")] GARANTI,
        [EnumMember(Value = "ISBANK")] ISBANK,
        [EnumMember(Value = "AKBANK")] AKBANK,
        [EnumMember(Value = "ZIRAATBANK")] ZIRAATBANK,

        [EnumMember(Value = "ZIRAATBANK_INNOVA")]
        ZIRAATBANK_INNOVA,
        [EnumMember(Value = "KUVEYTTURK")] KUVEYTTURK,
        [EnumMember(Value = "HALKBANK")] HALKBANK,
        [EnumMember(Value = "DENIZBANK")] DENIZBANK,
        [EnumMember(Value = "VAKIFBANK")] VAKIFBANK,
        [EnumMember(Value = "FINANSBANK")] FINANSBANK,

        [EnumMember(Value = "FINANSBANK_ASSECO")]
        FINANSBANK_ASSECO,
        [EnumMember(Value = "FIBABANK")] FIBABANK,

        [EnumMember(Value = "FIBABANK_ASSECO")]
        FIBABANK_ASSECO,
        [EnumMember(Value = "ANADOLUBANK")] ANADOLUBANK,
        [EnumMember(Value = "PARAM_POS")] PARAM_POS,
        [EnumMember(Value = "IYZICO")] IYZICO,
        [EnumMember(Value = "SIPAY")] SIPAY,
        [EnumMember(Value = "PAYNET")] PAYNET,
        [EnumMember(Value = "PAYTR")] PAYTR,
        [EnumMember(Value = "BIRLESIK_ODEME")] BIRLESIK_ODEME,
        [EnumMember(Value = "MOKA")] MOKA,
        [EnumMember(Value = "STRIPE")] STRIPE,
        [EnumMember(Value = "TEB")] TEB,
        [EnumMember(Value = "IPARA")] IPARA,
        [EnumMember(Value = "OZAN")] OZAN,
        [EnumMember(Value = "BRAINTREE")] BRAINTREE,
        [EnumMember(Value = "NKOLAY")] NKOLAY,
        [EnumMember(Value = "PAYTABS")] PAYTABS,
        [EnumMember(Value = "PAYBULL")] PAYBULL,
        [EnumMember(Value = "ELEKSE")] ELEKSE,
        [EnumMember(Value = "ALGORITMA")] ALGORITMA,
        [EnumMember(Value = "PAYCELL")] PAYCELL,
        [EnumMember(Value = "TAMI")] TAMI,
        [EnumMember(Value = "QNB_PAY")] QNB_PAY,
        [EnumMember(Value = "AKBANK_VPOS")] AKBANK_VPOS,
        [EnumMember(Value = "TAP")] TAP,
<<<<<<< HEAD
=======
        [EnumMember(Value = "RUBIK")] RUBIK,
>>>>>>> master
    }
}