using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RemittanceType
    {
        [EnumMember(Value = "SEND")] Send,
        [EnumMember(Value = "RECEIVE")] Receive
    }
}