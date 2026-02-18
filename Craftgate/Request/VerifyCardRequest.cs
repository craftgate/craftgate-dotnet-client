using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class VerifyCardRequest
    {
        public VerifyCard Card { get; set; }
        public CardVerificationAuthType? PaymentAuthenticationType { get; set; }
        public decimal? VerificationPrice { get; set; }
        public Currency? Currency { get; set; }
        public string ClientIp { get; set; }
        public string ConversationId { get; set; }
        public string CallbackUrl { get; set; }
    }
}
