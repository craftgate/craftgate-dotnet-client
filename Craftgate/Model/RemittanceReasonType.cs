using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum RemittanceReasonType
    {
        [EnumMember(Value = "REMITTANCE")] Remittance,
        [EnumMember(Value = "LOYALTY")] Loyalty
    }
}