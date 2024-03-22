using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class MerchantPosCommissionResponse
    {
        public long Id;
        public Status Status;
        public int Installment;
        public int? BlockageDay;
        public string InstallmentLabel;
        public string CardBrandName;
        public decimal? BankOnUsCreditCardCommissionRate;
        public decimal? BankNotOnUsCreditCardCommissionRate;
        public decimal? BankOnUsDebitCardCommissionRate;
        public decimal? BankNotOnUsDebitCardCommissionRate;
        public decimal? BankForeignCardCommissionRate;
        public decimal? MerchantCommissionRate;
    }
}