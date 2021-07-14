namespace Craftgate.Request
{
    public class UpdateCardRequest
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
    }
}