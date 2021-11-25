namespace Craftgate.Request
{
    public class RetrieveLoyaltiesRequest
    {
        public string CardNumber { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
        public string Cvc { get; set; }

        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}