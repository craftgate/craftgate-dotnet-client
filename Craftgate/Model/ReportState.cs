using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ReportState
    {
        [EnumMember(Value = "DEMANDED")] DEMANDED,
        [EnumMember(Value = "READY")] READY,
        [EnumMember(Value = "FAILED")] FAILED
    }
}
