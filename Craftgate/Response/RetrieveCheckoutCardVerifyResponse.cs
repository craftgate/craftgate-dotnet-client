using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class RetrieveCheckoutCardVerifyResponse
    {
        public string Token { get; set; }
        public StoredCardResponse Card { get; set; }
    }
}
