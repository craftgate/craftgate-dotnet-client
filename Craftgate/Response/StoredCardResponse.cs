using System;

namespace Craftgate.Response.Dto
{
    public class StoredCardResponse
    {
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string CardHolderName { get; set; }
        public string CardAlias { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string CardBankName { get; set; }
        public long? CardBankId { get; set; }
        public string CardExpiryStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}