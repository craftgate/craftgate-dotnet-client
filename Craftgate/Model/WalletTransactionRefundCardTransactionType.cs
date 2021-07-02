using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WalletTransactionRefundCardTransactionType
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT,
        [EnumMember(Value = "PAYMENT_TX")] PAYMENT_TX
    }
}