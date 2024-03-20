using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ClientType
    {
        [EnumMember(Value = "M")] M,

        [EnumMember(Value = "W")] W,
    }
}