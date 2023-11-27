using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WebhookEventType
    {
        [EnumMember(Value = "API_AUTH")] API_AUTH,
        [EnumMember(Value = "API_VERIFY_AND_AUTH")] API_VERIFY_AND_AUTH,
        [EnumMember(Value = "CHECKOUTFORM_AUTH")] CHECKOUTFORM_AUTH,
        [EnumMember(Value = "THREEDS_VERIFY")] THREEDS_VERIFY,
        [EnumMember(Value = "REFUND")] REFUND,
        [EnumMember(Value = "REFUND_TX")] REFUND_TX,
        [EnumMember(Value = "PAYOUT_COMPLETED")] PAYOUT_COMPLETED,
        [EnumMember(Value = "AUTOPILOT")] AUTOPILOT,
        [EnumMember(Value = "WALLET_CREATED")] WALLET_CREATED,
        [EnumMember(Value = "WALLET_TX_CREATED")] WALLET_TX_CREATED,
        [EnumMember(Value = "BNPL_NOTIFICATION")] BNPL_NOTIFICATION,
        [EnumMember(Value = "BANK_ACCOUNT_TRACKING_RECORD")] BANK_ACCOUNT_TRACKING_RECORD
    }
}