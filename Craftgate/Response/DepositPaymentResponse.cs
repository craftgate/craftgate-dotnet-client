using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class DepositPaymentResponse
    {
        public long? Id { get; set; }
        public decimal? Price { get; set; }
        public Currency Currency { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public string OrderId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}