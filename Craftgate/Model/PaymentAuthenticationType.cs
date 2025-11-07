using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentAuthenticationType
    {
        [EnumMember(Value = "THREE_DS")] THREE_DS,
        [EnumMember(Value = "NON_THREE_DS")] NON_THREE_DS,
        [EnumMember(Value = "BKM_EXPRESS")] BKM_EXPRESS
    }
}