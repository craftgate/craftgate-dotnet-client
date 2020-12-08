using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundType
    {
        [EnumMember(Value = "CANCEL")] Cancel,

        [EnumMember(Value = "REFUND")] Refund
    }
}