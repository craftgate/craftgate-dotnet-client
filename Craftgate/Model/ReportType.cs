using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ReportType
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT, 
        [EnumMember(Value = "TRANSACTION")] TRANSACTION,
    }
}