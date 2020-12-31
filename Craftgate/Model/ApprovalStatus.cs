using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ApprovalStatus
    {
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "SUCCESS")] Success
    }
}