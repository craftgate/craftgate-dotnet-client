using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RecordType
    {
        [EnumMember(Value = "SEND")] SEND,

        [EnumMember(Value = "RECEIVE")] RECEIVE
    }
}