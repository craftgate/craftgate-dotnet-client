using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FraudCheckStatus
    {
        [EnumMember(Value = "WAITING")] WAITING,
        
        [EnumMember(Value = "FRAUD")] FRAUD,

        [EnumMember(Value = "NOT_FRAUD")] NOT_FRAUD,
    }
}