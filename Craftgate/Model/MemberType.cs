using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum MemberType
    {
        [EnumMember(Value = "PERSONAL")] PERSONAL,

        [EnumMember(Value = "PRIVATE_COMPANY")]
        PRIVATE_COMPANY,

        [EnumMember(Value = "LIMITED_OR_JOINT_STOCK_COMPANY")]
        LIMITED_OR_JOINT_STOCK_COMPANY
    }
}