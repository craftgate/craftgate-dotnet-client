using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RefundStatus
    {
        [EnumMember(Value = "FAILURE")] FAILURE,

        [EnumMember(Value = "SUCCESS")] SUCCESS,
        
        [EnumMember(Value = "WAITING")] WAITING
    }
}