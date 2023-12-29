using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currency
    {
        [EnumMember(Value = "TRY")] TRY,
        [EnumMember(Value = "USD")] USD,
        [EnumMember(Value = "EUR")] EUR,
        [EnumMember(Value = "GBP")] GBP,
        [EnumMember(Value = "ARS")] ARS,
        [EnumMember(Value = "BRL")] BRL,
        [EnumMember(Value = "CNY")] CNY,
        [EnumMember(Value = "AED")] AED,
        [EnumMember(Value = "IQD")] IQD,
        [EnumMember(Value = "AZN")] AZN,
        [EnumMember(Value = "KZT")] KZT,
        [EnumMember(Value = "KWD")] KWD,
        [EnumMember(Value = "SAR")] SAR,
        [EnumMember(Value = "BHD")] BHD,
        [EnumMember(Value = "RUB")] RUB,
        [EnumMember(Value = "JPY")] JPY
    }
}
