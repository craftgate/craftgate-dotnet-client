using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ReportType
    {
        [EnumMember(Value = "PAYMENT")] PAYMENT, 
        [EnumMember(Value = "TRANSACTION")] TRANSACTION,
        [EnumMember(Value = "SETTLEMENT")] SETTLEMENT,
        [EnumMember(Value = "SUB_MERCHANT_MEMBER_WALLET_TX")] SUB_MERCHANT_MEMBER_WALLET_TX,
    }
}