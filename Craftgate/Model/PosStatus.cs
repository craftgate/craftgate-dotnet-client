using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PosStatus
    {
        [EnumMember(Value = "DELETED")] DELETED,
        [EnumMember(Value = "PASSIVE")] PASSIVE,
        [EnumMember(Value = "ACTIVE")] ACTIVE,
        [EnumMember(Value = "REFUND_ONLY")] REFUND_ONLY,
        [EnumMember(Value = "AUTOPILOT")] AUTOPILOT
    }
}