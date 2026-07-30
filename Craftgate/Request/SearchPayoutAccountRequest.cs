using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPayoutAccountRequest : BaseRequest
    {
        public Currency? Currency { get; set; }
        public AccountOwner? AccountOwner { get; set; }
        public long? SubMerchantMemberId { get; set; }
        public int? Page { get; set; } = 0;
        public int? Size { get; set; } = 10;
    }
}