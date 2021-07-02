using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementResultStatus
    {
        [EnumMember(Value = "SUCCESS")] SUCCESS,
        [EnumMember(Value = "FAILURE")] FAILURE,

        [EnumMember(Value = "NO_RECORD_FOUND")]
        NO_RECORD_FOUND
    }
}