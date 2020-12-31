using Craftgate.Model;

namespace Craftgate.Response
{
    public class BinNumberResponse
    {
        public string BinNumber { get; set; }
        public CardType? CardType { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string BankName { get; set; }
        public long? BankCode { get; set; }
        public bool? Commercial { get; set; }
    }
}