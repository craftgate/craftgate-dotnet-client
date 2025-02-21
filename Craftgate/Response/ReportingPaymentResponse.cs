using System.Collections.Generic;
using Craftgate.Response.Common;

namespace Craftgate.Response
{
    public class ReportingPaymentResponse : BasePaymentResponse
    {
        public int RetryCount { get; set; }
        public decimal RefundablePrice { get; set; }
        public string RefundStatus { get; set; }
        public string CardIssuerBankName { get; set; }
        public MemberResponse BuyerMember { get; set; }
        public IList<ReportingPaymentRefundResponse> Refunds { get; set; }
    }
}