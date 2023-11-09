using System.Collections.Generic;

namespace Craftgate.Response.Dto
{
    public class BnplBankOfferTerm
    {
        public int? Term { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal AnnualInterestRate { get; set; }
    }
}