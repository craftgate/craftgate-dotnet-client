using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FileStatus
    {
        [EnumMember(Value = "CREATED")] CREATED,

        [EnumMember(Value = "UPLOADED")] UPLOADED,

        [EnumMember(Value = "APPROVED")] APPROVED
    }
}