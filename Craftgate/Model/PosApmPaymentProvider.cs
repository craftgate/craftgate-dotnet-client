using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PosApmPaymentProvider
    {
        [EnumMember(Value = "YKB_WORLD_PAY")] YKB_WORLD_PAY,
        [EnumMember(Value = "YKB_WORLD_PAY_SHOPPING_LOAN")] YKB_WORLD_PAY_SHOPPING_LOAN,
        [EnumMember(Value = "GOOGLEPAY")] GOOGLEPAY,
        [EnumMember(Value = "GARANTI_PAY")] GARANTI_PAY
    }
}