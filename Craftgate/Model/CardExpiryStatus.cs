using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardExpiryStatus
    {
        [EnumMember(Value = "EXPIRED")] EXPIRED,

        [EnumMember(Value = "WILL_EXPIRE_NEXT_MONTH")] WILL_EXPIRE_NEXT_MONTH,

        [EnumMember(Value = "NOT_EXPIRED")] NOT_EXPIRED,
    }
}