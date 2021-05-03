using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum SettlementResultStatus
    {
        [EnumMember(Value = "SUCCESS")] Success,
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "NO_RECORD_FOUND")]
        NoRecordFound
    }
}