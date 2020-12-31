using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum MemberType
    {
        [EnumMember(Value = "PERSONAL")] Personal,

        [EnumMember(Value = "PRIVATE_COMPANY")]
        Private,

        [EnumMember(Value = "LIMITED_OR_JOINT_STOCK_COMPANY")]
        LimitedOrJointStockCompany
    }
}