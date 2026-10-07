using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FraudRuleScope
    {
        [EnumMember(Value = "MERCHANT")] MERCHANT,
        [EnumMember(Value = "GLOBAL")] GLOBAL

    }
}
