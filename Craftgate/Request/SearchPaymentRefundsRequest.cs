using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchPaymentRefundsRequest
    {
        public long? Id { get; set; }
        public long? PaymentId { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public RefundStatus? Status { get; set; }
        public Currency? Currency { get; set; }
        public decimal? MinRefundPrice { get; set; }
        public decimal? MaxRefundPrice { get; set; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}