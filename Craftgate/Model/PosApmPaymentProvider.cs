using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PosApmPaymentProvider
    {
        [EnumMember(Value = "YKB_WORLD_PAY")] YKB_WORLD_PAY,
        [EnumMember(Value = "GOOGLEPAY")] GOOGLEPAY,
        [EnumMember(Value = "APPLEPAY")] APPLEPAY
    }
}