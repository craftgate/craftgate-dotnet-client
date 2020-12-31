using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currency
    {
        [EnumMember(Value = "TRY")] Try
    }
}