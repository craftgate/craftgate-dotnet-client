using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardMigrationProvider
    {
        [EnumMember(Value = "IYZICO")] IYZICO,
        [EnumMember(Value = "IPARA")] IPARA,
        [EnumMember(Value = "BIRLESIK_ODEME")] BIRLESIK_ODEME,
        [EnumMember(Value = "MEX")] MEX
    }
}