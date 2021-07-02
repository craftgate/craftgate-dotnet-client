using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardType
    {
        [EnumMember(Value = "CREDIT_CARD")] CREDIT_CARD,

        [EnumMember(Value = "DEBIT_CARD")] DEBIT_CARD,

        [EnumMember(Value = "PREPAID_CARD")] PREPAID_CARD
    }
}