using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentMethod
    {
        [EnumMember(Value = "MASTERPASS")] MASTERPASS,
        [EnumMember(Value = "CARD")] CARD
    }
}