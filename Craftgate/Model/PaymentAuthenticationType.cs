using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentAuthenticationType
    {
        [EnumMember(Value = "THREE_DS")] THREE_DS,
        [EnumMember(Value = "NON_THREE_DS")] NON_THREE_DS,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS,
        [EnumMember(Value = "THREE_DS_FALLBACK_TO_NON_THREE_DS")] THREE_DS_FALLBACK_TO_NON_THREE_DS,
        [EnumMember(Value = "GOOGLEPAY")] GOOGLEPAY,
        [EnumMember(Value = "APPLEPAY")] APPLEPAY,
        [EnumMember(Value = "YKB_WORLD_PAY")] YKB_WORLD_PAY,
        [EnumMember(Value = "YKB_WORLD_PAY_SHOPPING_LOAN")] YKB_WORLD_PAY_SHOPPING_LOAN,
        [EnumMember(Value = "GARANTI_PAY")] GARANTI_PAY,
        [EnumMember(Value = "JUZDAN")] JUZDAN
    }
}