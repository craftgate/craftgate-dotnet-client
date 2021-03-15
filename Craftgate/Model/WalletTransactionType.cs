using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionType
    {
        [EnumMember(Value = "PAYMENT_REDEEM")] PaymentRedeem,
        [EnumMember(Value = "REFUND_DEPOSIT")] RefundDeposit,
        [EnumMember(Value = "WITHDRAW")] Withdraw,
        [EnumMember(Value = "REFUND_TX_DEPOSIT")] RefundTxDeposit,
        [EnumMember(Value = "CANCEL_REFUND_TO_WALLET")] CancelRefundToWallet,
        [EnumMember(Value = "CANCEL_REFUND_WALLET_TO_CARD")] CancelRefundToCard,
        [EnumMember(Value = "REFUND_TX_TO_WALLET")] RefundTxToWallet,
        [EnumMember(Value = "REFUND_WALLET_TX_TO_CARD")] RefundTxToCard,
        [EnumMember(Value = "MANUAL_REFUND_TX_TO_WALLET")] ManualRefundTxToWallet,
        [EnumMember(Value = "DEPOSIT_FROM_CARD")] DepositFromCard,
        [EnumMember(Value = "SETTLEMENT_EARNINGS")] SettlementEarnings,
        [EnumMember(Value = "REMITTANCE")] Remittance,
        [EnumMember(Value = "LOYALTY")] Loyalty,
        [EnumMember(Value = "WITHDRAW_CANCEL")] WithdrawCancel,
        [EnumMember(Value = "MERCHANT_BALANCE_RESET")] MerchantBalanceReset
    }
}