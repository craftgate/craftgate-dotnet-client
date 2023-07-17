using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum AccountOwner
    {
        [EnumMember(Value = "MERCHANT")] MERCHANT,
        [EnumMember(Value = "SUB_MERCHANT_MEMBER")] SUB_MERCHANT_MEMBER,
    }
}