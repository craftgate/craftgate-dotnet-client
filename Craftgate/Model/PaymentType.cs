using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentType
    {
        [EnumMember(Value = "CARD_PAYMENT")] CardPayment,

        [EnumMember(Value = "DEPOSIT_PAYMENT")]
        DepositPayment,

        [EnumMember(Value = "WALLET_PAYMENT")] WalletPayment,

        [EnumMember(Value = "CARD_AND_WALLET_PAYMENT")]
        CardAndWalletPayment,

        [EnumMember(Value = "BANK_TRANSFER")] BankTransfer
    }
}