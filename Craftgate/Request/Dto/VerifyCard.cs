namespace Craftgate.Request.Dto
{
    public class VerifyCard
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
        public string Cvc { get; set; }
        public string CardAlias { get; set; }
        public string CardUserKey { get; set; }
    }
}
