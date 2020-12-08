using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentStatus
    {
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "SUCCESS")] Success,

        [EnumMember(Value = "INIT_THREEDS")] InitThreeds,

        [EnumMember(Value = "CALLBACK_THREEDS")]
        CallbackThreeds
    }
}