using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum Status
    {
        [EnumMember(Value = "ACTIVE")] Active,
        [EnumMember(Value = "PASSIVE")] Passive
    }
}