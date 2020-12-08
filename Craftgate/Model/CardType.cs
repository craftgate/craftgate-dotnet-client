using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardType
    {
        [EnumMember(Value = "CREDIT_CARD")] CreditCard,

        [EnumMember(Value = "DEBIT_CARD")] DebitCard,

        [EnumMember(Value = "PREPAID_CARD")] PrepaidCard
    }
}