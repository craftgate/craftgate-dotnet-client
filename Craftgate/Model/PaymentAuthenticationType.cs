using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentAuthenticationType
    {
        [EnumMember(Value = "THREE_DS")] THREE_DS,
        [EnumMember(Value = "NON_THREE_DS")] NON_THREE_DS,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS
    }
}