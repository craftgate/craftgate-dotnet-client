using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum MasterpassValidationType
    {
        [EnumMember(Value = "NONE")] NONE,
        [EnumMember(Value = "OTP")] OTP,
        [EnumMember(Value = "THREE_DS")] THREE_DS
    }
} 