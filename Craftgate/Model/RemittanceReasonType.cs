using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RemittanceReasonType
    {
        [EnumMember(Value = "SUBMERCHANT_SEND_RECEIVE")]
        SUBMERCHANT_SEND_RECEIVE,

        [EnumMember(Value = "REDEEM_ONLY_LOYALTY")]
        REDEEM_ONLY_LOYALTY
    }
}