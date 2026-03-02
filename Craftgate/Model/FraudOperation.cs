using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FraudOperation
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT,
        [EnumMember(Value = "LOYALTY")] LOYALTY

    }
}