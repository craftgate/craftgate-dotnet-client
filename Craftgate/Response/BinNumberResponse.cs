namespace Craftgate.Response
{
    public class BinNumberResponse
    {
        public string BinNumber { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string BankName { get; set; }
        public long? BankCode { get; set; }
        public bool? Commercial { get; set; }
    }
}