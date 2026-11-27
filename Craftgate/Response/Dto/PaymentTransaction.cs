using System;

namespace Craftgate.Response.Dto
{
    public class PaymentTransaction
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal WalletPrice { get; set; }
        public decimal MerchantCommissionRate { get; set; }
        public decimal MerchantCommissionRateAmount { get; set; }
        public long SubMerchantMemberId { get; set; }
        public decimal SubMerchantMemberPrice { get; set; }
        public string TransactionStatus { get; set; }
        public DateTime BlockageResolvedDate { get; set; }
    }
}