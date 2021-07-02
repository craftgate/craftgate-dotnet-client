using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SettlementSource
    {
        [EnumMember(Value = "COLLECTION")] COLLECTION,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW,
        [EnumMember(Value = "BOUNCED")] BOUNCED
    }
}