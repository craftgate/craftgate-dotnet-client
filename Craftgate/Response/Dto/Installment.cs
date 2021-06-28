using System.Collections.Generic;

namespace Craftgate.Response.Dto
{
    public class Installment
    {
        public string BinNumber { get; set; }
        public decimal? Price { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string BankName { get; set; }
        public long? BankCode { get; set; }
        public bool? Force3ds { get; set; }
        public bool? CvcRequired { get; set; }
        public bool? Commercial { get; set; }
        public List<InstallmentPriceDto> InstallmentPrices { get; set; }
    }
}