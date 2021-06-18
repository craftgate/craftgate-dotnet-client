using System;

namespace Craftgate.Response.Dto
{
    public class PayoutBouncedTransaction
    {
        public long Id;
        public string Iban;
        public DateTime CreatedDate;
        public DateTime UpdatedDate;
        public long PayoutId;
        public decimal PayoutAmount;
        public string ContactName;
        public string ContactSurname;
        public string LegalCompanyTitle;
        public string RowDescription;
    }
}