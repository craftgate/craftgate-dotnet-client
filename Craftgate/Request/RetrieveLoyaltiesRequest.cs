using Craftgate.Request.Dto;

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

        public string ClientIp { get; set; }
        public string ConversationId { get; set; }
        public FraudCheckParameters FraudParams { get; set; }
    }
}