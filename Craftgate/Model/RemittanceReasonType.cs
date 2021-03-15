using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RemittanceReasonType
    {
        [EnumMember(Value = "SUBMERCHANT_SEND_RECEIVE")] SubMerchantSendReceive,
        [EnumMember(Value = "REDEEM_ONLY_LOYALTY")] RedeemOnlyLoyalty
    }
}