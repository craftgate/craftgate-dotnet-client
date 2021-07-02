using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MerchantType
    {
        [EnumMember(Value = "MERCHANT")] MERCHANT,

        [EnumMember(Value = "SUB_MERCHANT_MEMBER")]
        SUB_MERCHANT_MEMBER
    }
}