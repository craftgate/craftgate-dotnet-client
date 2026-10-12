using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum TokenizedCardType
    {
        [EnumMember(Value = "APPLE_PAY")] APPLE_PAY,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS,
    }
}