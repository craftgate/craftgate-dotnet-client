using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchPaymentsRequest
    {
        public long? PaymentId { get; set; }
        public long? PaymentTransactionId { get; set; }
        public long? SubMerchantMemberId { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string OrderId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public PaymentSource? PaymentType { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public Currency? Currency { get; set; }
        public decimal? MinPaidPrice { get; set; }
        public decimal? MaxPaidPrice { get; set; }
        public int? Installment { get; set; }
        public bool? IsThreeDS { get; set; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}