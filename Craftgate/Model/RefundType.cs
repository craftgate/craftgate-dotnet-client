using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundType
    {
        [EnumMember(Value = "CANCEL")] CANCEL,

        [EnumMember(Value = "REFUND")] REFUND
    }
}