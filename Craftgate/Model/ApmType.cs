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
        [EnumMember(Value = "PAYPAL")] PAYPAL,
        [EnumMember(Value = "AFTERPAY")] AFTERPAY,
        [EnumMember(Value = "FUND_TRANSFER")] FUND_TRANSFER,
        [EnumMember(Value = "CASH_ON_DELIVERY")] CASH_ON_DELIVERY
    }
}