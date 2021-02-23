using System;
using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class PaymentRefundResponse
    {
        public long? Id { get; set; }
        public string ConversationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public RefundStatus? Status { get; set; }
        public decimal? RefundPrice { get; set; }
        public decimal? RefundBankPrice { get; set; }
        public decimal? RefundWalletPrice { get; set; }
        public RefundType? RefundType { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public RefundDestinationType? RefundDestinationType { get; set; }
        public Currency Currency { get; set; }
        public long? PaymentId { get; set; }
        public IList<PaymentTransactionRefundResponse> PaymentTransactionRefunds { get; set; }
    }
}