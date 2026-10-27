using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PayoutApprovalStatus
    {
        [EnumMember(Value = "WAITING")] WAITING,
        [EnumMember(Value = "APPROVED")] APPROVED
    }
}