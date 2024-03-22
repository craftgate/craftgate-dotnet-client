using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PosOperationType
    {
        [EnumMember(Value = "STANDARD")] STANDARD,
        [EnumMember(Value = "PROVAUT")] PROVAUT,
        [EnumMember(Value = "PROVRFN")] PROVRFN,
        [EnumMember(Value = "PAYMENT")] PAYMENT,
        [EnumMember(Value = "REFUND")] REFUND,
        [EnumMember(Value = "INQUIRY")] INQUIRY
    }
}