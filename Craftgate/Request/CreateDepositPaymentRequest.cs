using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class CreateDepositPaymentRequest
    {
        public long? BuyerMemberId { get; set; }
        public decimal? Price { set; get; }
        public Currency Currency { get; set; }
        public string ConversationId { get; set; }
        public string CallbackUrl { get; set; }
        public string PosAlias { get; set; }
        public string ClientIp { get; set; }
        public Card Card { get; set; }
    }
}