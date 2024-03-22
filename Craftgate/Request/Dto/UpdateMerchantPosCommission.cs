using Craftgate.Model;

namespace Craftgate.Request.Dto
{
    public class UpdateMerchantPosCommission
    {
        public CardBrand CardBrandName { get; set; }
        public int Installment { get; set; }
        public Status Status { get; set; }
        public int? BlockageDay { get; set; }
        public string InstallmentLabel { get; set; }
        public decimal BankOnUsCreditCardCommissionRate { get; set; }
        public decimal? BankOnUsDebitCardCommissionRate { get; set; }
        public decimal? BankNotOnUsCreditCardCommissionRate { get; set; }
        public decimal? BankNotOnUsDebitCardCommissionRate { get; set; }
        public decimal? BankForeignCardCommissionRate { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
    }
}