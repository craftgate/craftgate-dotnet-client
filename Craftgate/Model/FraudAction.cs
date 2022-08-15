using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum FraudAction
    {
        [EnumMember(Value = "REVIEW")] REVIEW,

        [EnumMember(Value = "BLOCK")] BLOCK,
    }
}