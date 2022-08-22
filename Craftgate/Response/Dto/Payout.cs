namespace Craftgate.Response.Dto
{
    public class Payout
    {
        public decimal? PaidPrice { get; set; }
        public decimal? Parity { get; set; }
        public string Currency { get; set; }
        public decimal? MerchantPayoutAmount { get; set; }
        public decimal? SubMerchantMemberPayoutAmount { get; set; }
    }
}