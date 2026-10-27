using System;
using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PaymentTxPayoutResponse
    {
        public long PaymentTransactionId { get; set; }
        public string Currency { get; set; }
        public decimal? Parity { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? ApprovalStatusDate { get; set; }
        public DateTime? BlockageResolvedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<PayoutItem> PayoutItems { get; set; }
    }
}