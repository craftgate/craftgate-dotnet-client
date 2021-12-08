using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum LoyaltyType
    {
        [EnumMember(Value = "REWARD_MONEY")] REWARD_MONEY,
        [EnumMember(Value = "ADDITIONAL_INSTALLMENT")] ADDITIONAL_INSTALLMENT,
        [EnumMember(Value = "POSTPONING_INSTALLMENT")] POSTPONING_INSTALLMENT,
        [EnumMember(Value = "EXTRA_POINTS")] EXTRA_POINTS,
        [EnumMember(Value = "GAINING_MINUTES")] GAINING_MINUTES,
        [EnumMember(Value = "POSTPONING_STATEMENT")] POSTPONING_STATEMENT
    }
}