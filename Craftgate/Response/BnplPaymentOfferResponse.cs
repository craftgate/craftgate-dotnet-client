using System.Collections.Generic;

namespace Craftgate.Response.Dto
{
    public class BnplPaymentOfferResponse
    {
        public string OfferId { get; set; }
        public decimal Price { get; set; }
        public IList<BnplBankOffer> BankOffers { get; set; }
    }
}