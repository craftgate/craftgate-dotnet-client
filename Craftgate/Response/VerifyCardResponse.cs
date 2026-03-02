using Craftgate.Model;

namespace Craftgate.Response
{
    public class VerifyCardResponse
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string HtmlContent { get; set; }
        public string RedirectUrl { get; set; }
        public string MerchantCallbackUrl { get; set; }
        public RefundStatus? RefundStatus { get; set; }
        public CardVerifyStatus? CardVerifyStatus { get; set; }
    }
}
