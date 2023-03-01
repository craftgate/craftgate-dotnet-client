using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionRefundTransactionType
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT,
        [EnumMember(Value = "PAYMENT_TX")] PAYMENT_TX,
        [EnumMember(Value = "WALLET_TX")] WALLET_TX
    }
}