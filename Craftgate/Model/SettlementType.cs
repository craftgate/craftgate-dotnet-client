using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SettlementType
    {
        [EnumMember(Value = "SETTLEMENT")] Settlement,

        [EnumMember(Value = "BOUNCED_SETTLEMENT")]
        BouncedSettlement,
        [EnumMember(Value = "WITHDRAW")] Withdraw
    }
}