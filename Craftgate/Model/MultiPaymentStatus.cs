using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum MultiPaymentStatus
    {
        [EnumMember(Value = "CREATED")] CREATED,

        [EnumMember(Value = "COMPLETED")] COMPLETED
    }
}