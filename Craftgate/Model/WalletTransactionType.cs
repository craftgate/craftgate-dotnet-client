using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionType
    {
        [EnumMember(Value = "PAYMENT_REDEEM")] PAYMENT_REDEEM,
        [EnumMember(Value = "REFUND_DEPOSIT")] REFUND_DEPOSIT,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW,
        [EnumMember(Value = "REFUND_TX_DEPOSIT")] REFUND_TX_DEPOSIT,
        [EnumMember(Value = "CANCEL_REFUND_TO_WALLET")] CANCEL_REFUND_TO_WALLET,
        [EnumMember(Value = "CANCEL_REFUND_WALLET_TO_CARD")] CANCEL_REFUND_WALLET_TO_CARD,
        [EnumMember(Value = "REFUND_TX_TO_WALLET")] REFUND_TX_TO_WALLET,
        [EnumMember(Value = "REFUND_WALLET_TX_TO_CARD")] REFUND_WALLET_TX_TO_CARD,
        [EnumMember(Value = "REFUND_WALLET_TX_FUND_TRANSFER")] REFUND_WALLET_TX_FUND_TRANSFER,
        [EnumMember(Value = "MANUAL_REFUND_TX_TO_WALLET")] MANUAL_REFUND_TX_TO_WALLET,
        [EnumMember(Value = "DEPOSIT_FROM_CARD")] DEPOSIT_FROM_CARD,
        [EnumMember(Value = "DEPOSIT_FROM_APM")] DEPOSIT_FROM_APM,
        [EnumMember(Value = "DEPOSIT_FROM_FUND_TRANSFER")] DEPOSIT_FROM_FUND_TRANSFER,
        [EnumMember(Value = "SETTLEMENT_EARNINGS")] SETTLEMENT_EARNINGS,
        [EnumMember(Value = "REMITTANCE")] REMITTANCE,
        [EnumMember(Value = "LOYALTY")] LOYALTY,
        [EnumMember(Value = "WITHDRAW_CANCEL")] WITHDRAW_CANCEL,
        [EnumMember(Value = "MERCHANT_BALANCE_RESET")] MERCHANT_BALANCE_RESET
    }
}