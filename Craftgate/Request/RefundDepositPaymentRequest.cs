namespace Craftgate.Request
{
    public class RefundDepositPaymentRequest
    {
        public decimal Price { get; set; }
        public string ConversationId { get; set; }
    }
}