using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApmStatus
    {
        [EnumMember(Value = "DELETED")] DELETED,
        [EnumMember(Value = "PASSIVE")] PASSIVE,
        [EnumMember(Value = "ACTIVE")] ACTIVE
    }
}