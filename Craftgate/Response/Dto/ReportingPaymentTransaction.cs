using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class ReportingPaymentTransaction : PaymentTransaction
    {
        public DateTime CreatedDate { get; set; }
        public DateTime TransactionStatusDate { get; set; }
        public decimal RefundablePrice { get; set; }
        public MemberResponse SubMerchantMember { get; set; }
        public PaymentRefundStatus RefundStatus { get; set; }
        public PayoutStatus PayoutStatus { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal BankCommissionRateAmount { get; set; }
    }
}