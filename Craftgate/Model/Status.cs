using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum Status
    {
        [EnumMember(Value = "ACTIVE")] ACTIVE,
        [EnumMember(Value = "PASSIVE")] PASSIVE
    }
}