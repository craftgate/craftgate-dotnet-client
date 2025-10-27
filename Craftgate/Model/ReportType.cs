using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportType
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT, 
        [EnumMember(Value = "TRANSACTION")] TRANSACTION,
    }
}