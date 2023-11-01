using System.Collections.Generic;

namespace Craftgate.Response.Dto
{
    public class BnplBankOffer
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankIconUrl { get; set; }
        public string BankTableBannerMessage { get; set; }
        public string BankSmallBannerMessage { get; set; }
        public bool? IsSupportNonCustomer { get; set; }
        public IList<BnplBankOfferTerm> BankOfferTerms { get; set; }
    }
}