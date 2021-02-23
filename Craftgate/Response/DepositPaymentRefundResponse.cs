using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class DepositPaymentRefundResponse
    {
        public long? Id { get; set; }
        public long? PaymentId { get; set; }
        public Currency Currency { get; set; }
        public RefundStatus? Status { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public string ConversationId { get; set; }
        public RefundType? RefundType { get; set; }
        public decimal? RefundPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}