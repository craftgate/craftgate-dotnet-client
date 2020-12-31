using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundStatus
    {
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "SUCCESS")] Success
    }
}