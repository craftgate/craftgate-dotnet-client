namespace Craftgate.Request.Dto
{
    public class PaymentItem
    {
        public string Name { get; set; }
        public decimal? Price { set; get; }
        public string ExternalId { get; set; }
        public long? SubMerchantMemberId { get; set; }
        public decimal? SubMerchantMemberPrice { get; set; }
        public decimal? SubMerchantMemberTaxPrice { get; set; }
    }
}