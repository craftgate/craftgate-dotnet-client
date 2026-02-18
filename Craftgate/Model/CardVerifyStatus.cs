using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardVerifyStatus
    {
        [EnumMember(Value = "SUCCESS")] SUCCESS,
        [EnumMember(Value = "FAILURE")] FAILURE,
        [EnumMember(Value = "THREE_DS_PENDING")] THREE_DS_PENDING
    }
}
