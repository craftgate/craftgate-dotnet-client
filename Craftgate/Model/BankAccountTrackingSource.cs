using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum BankAccountTrackingSource
    {
        [EnumMember(Value = "YKB")] YKB,
        [EnumMember(Value = "GARANTI")] GARANTI
    }
}