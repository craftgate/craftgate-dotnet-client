using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ReportPeriod
    {
        [EnumMember(Value = "INSTANT")] INSTANT,
        [EnumMember(Value = "DAILY")] DAILY,
    }
}