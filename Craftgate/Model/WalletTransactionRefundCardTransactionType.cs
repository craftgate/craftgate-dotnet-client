using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionRefundCardTransactionType
    {
        [EnumMember(Value = "PAYMENT")] Payment,
        [EnumMember(Value = "PAYMENT_TX")] PaymentTx
    }
}