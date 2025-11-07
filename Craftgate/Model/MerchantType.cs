using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum MerchantType
    {
        [EnumMember(Value = "MERCHANT")] MERCHANT,

        [EnumMember(Value = "SUB_MERCHANT_MEMBER")]
        SUB_MERCHANT_MEMBER
    }
}