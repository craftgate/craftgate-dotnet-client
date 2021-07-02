using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ApprovalStatus
    {
        [EnumMember(Value = "FAILURE")] FAILURE,

        [EnumMember(Value = "SUCCESS")] SUCCESS
    }
}