using Craftgate.Model;

namespace Craftgate.Request
{
    public class InitCheckoutCardVerifyRequest
    {
        public decimal? VerificationPrice { get; set; }
        public Currency? Currency { get; set; }
        public string ConversationId { get; set; }
        public string CallbackUrl { get; set; }
        public string CardUserKey { get; set; }
        public CardVerificationAuthType? PaymentAuthenticationType { get; set; }
        public long? Ttl { get; set; }
    }
}
