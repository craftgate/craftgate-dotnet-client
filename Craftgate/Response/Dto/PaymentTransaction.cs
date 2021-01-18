using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class PaymentTransaction
    {
        public long Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal WalletPrice { get; set; }
        public decimal MerchantCommissionRate { get; set; }
        public decimal MerchantCommissionRateAmount { get; set; }
        public decimal MerchantPayoutAmount { get; set; }
        public long SubMerchantMemberId { get; set; }
        public decimal SubMerchantMemberPrice { get; set; }
        public decimal SubMerchantMemberPayoutRate { get; set; }
        public decimal SubMerchantMemberPayoutAmount { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public DateTime BlockageResolvedDate { get; set; }
        public Payout Payout { get; set; }
    }
}