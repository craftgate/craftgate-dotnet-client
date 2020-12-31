using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class Payout
    {
        public decimal? PaidPrice { get; set; }
        public Currency Currency { get; set; }
        public decimal? MerchantPayoutAmount { get; set; }
        public decimal? SubMerchantMemberPayoutAmount { get; set; }
    }
}