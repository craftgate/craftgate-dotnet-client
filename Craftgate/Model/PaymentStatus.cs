using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentStatus
    {
        [EnumMember(Value = "FAILURE")] FAILURE,

        [EnumMember(Value = "SUCCESS")] SUCCESS,

        [EnumMember(Value = "INIT_THREEDS")] INIT_THREEDS,

        [EnumMember(Value = "CALLBACK_THREEDS")]
        CALLBACK_THREEDS,

        [EnumMember(Value = "WAITING")] WAITING
    }
}