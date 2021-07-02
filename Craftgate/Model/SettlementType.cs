using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SettlementType
    {
        [EnumMember(Value = "SETTLEMENT")] SETTLEMENT,

        [EnumMember(Value = "BOUNCED_SETTLEMENT")]
        BOUNCED_SETTLEMENT,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW
    }
}