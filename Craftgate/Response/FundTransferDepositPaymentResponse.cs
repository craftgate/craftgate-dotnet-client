using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class FundTransferDepositPaymentResponse
    {
        public string Currency { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public WalletTransaction WalletTransaction { get; set; }
    }
}