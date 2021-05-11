using System;

namespace Craftgate.Response.Dto
{
    public class ReportingPaymentTransaction : PaymentTransaction
    {
        public DateTime CreatedDate { get; set; }
        public DateTime TransactionStatusDate { get; set; }
        public decimal RefundablePrice { get; set; }
        public MemberResponse SubMerchantMember { get; set; }
        public string RefundStatus { get; set; }
        public PayoutStatus PayoutStatus { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal BankCommissionRateAmount { get; set; }
    }
}