using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionType
    {
        [EnumMember(Value = "PAYMENT_REDEEM")] PaymentRedeem,
        [EnumMember(Value = "REFUND_DEPOSIT")] RefundDeposit,
        [EnumMember(Value = "REFUND_TX_DEPOSIT")] RefundTxDeposit,
        [EnumMember(Value = "CANCEL_REFUND_TO_WALLET")] CancelRefundToWallet,
        [EnumMember(Value = "REFUND_TX_TO_WALLET")] RefundTxToWallet,
        [EnumMember(Value = "MANUAL_REFUND_TX_TO_WALLET")] ManualRefundTxToWallet,
        [EnumMember(Value = "DEPOSIT_FROM_CARD")] DepositFromCard,
        [EnumMember(Value = "REMITTANCE")] Remittance,
        [EnumMember(Value = "LOYALTY")] Loyalty
    }
}