using System;

namespace Craftgate.Response.Dto
{
    public class FraudPaymentData
    {
        public DateTime PaymentDate  { get; set; }
        public string ConversationId { get; set; }
        public decimal PaidPrice { get; set; }
        public string Currency { get; set; }
        public long? BuyerId { get; set; }
        public string ClientIp { get; set; }
    }
}