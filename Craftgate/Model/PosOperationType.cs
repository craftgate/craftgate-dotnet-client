using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PosOperationType
    {
        [EnumMember(Value = "STANDARD")] STANDARD,
        [EnumMember(Value = "PROVAUT")] PROVAUT,
        [EnumMember(Value = "PROVRFN")] PROVRFN,
        [EnumMember(Value = "PAYMENT")] PAYMENT,
        [EnumMember(Value = "REFUND")] REFUND,
        [EnumMember(Value = "INQUIRY")] INQUIRY
    }
}