using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class StoredCardResponse
    {
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
        public string CardHolderName { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string CardAlias { get; set; }
        public CardType? CardType { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string CardBankName { get; set; }
        public long? CardBankId { get; set; }
    }
}