using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RemittanceType
    {
        [EnumMember(Value = "SEND")] SEND,
        [EnumMember(Value = "RECEIVE")] RECEIVE
    }
}