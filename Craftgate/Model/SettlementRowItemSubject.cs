using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementRowItemSubject
    {
        [EnumMember(Value = "PAYMENT_TX")] PAYMENT_TX,
        [EnumMember(Value = "REFUND")] REFUND,
        [EnumMember(Value = "REFUND_TX")] REFUND_TX,
        [EnumMember(Value = "MONEY_TRANSFER")] MONEY_TRANSFER,
        [EnumMember(Value = "WITHDRAW")] WITHDRAW
    }
}