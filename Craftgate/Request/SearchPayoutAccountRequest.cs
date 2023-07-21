using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchPayoutAccountRequest
    {
        public Currency? Currency { get; set; }
        public AccountOwner? AccountOwner { get; set; }
        public long? SubMerchantMemberId { get; set; }
        public int? Page { get; set; } = 0;
        public int? Size { get; set; } = 10;
    }
}