using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class CreateFundTransferDepositPaymentRequest
    {
        public decimal? Price { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public string ClientIp { get; set; }
    }
}