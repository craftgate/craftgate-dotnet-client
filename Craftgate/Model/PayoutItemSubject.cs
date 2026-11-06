using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PayoutItemSubject
    {
        [EnumMember(Value = "PAYMENT_TX")] PAYMENT_TX,
        [EnumMember(Value = "REFUND")] REFUND,
        [EnumMember(Value = "REFUND_TX")] REFUND_TX
    }
}