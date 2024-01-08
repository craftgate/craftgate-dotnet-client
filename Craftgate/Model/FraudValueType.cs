using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FraudValueType
    {
        [EnumMember(Value = "CARD")] CARD,
        [EnumMember(Value = "IP")] IP,
        [EnumMember(Value = "PHONE_NUMBER")] PHONE_NUMBER,
        [EnumMember(Value = "EMAIL")] EMAIL,
        [EnumMember(Value = "OTHER")] OTHER

    }
}