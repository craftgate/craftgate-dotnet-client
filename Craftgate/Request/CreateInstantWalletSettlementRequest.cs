using System.Collections.Generic;

namespace Craftgate.Request
{
    public class CreateInstantWalletSettlementRequest
    {
        public ISet<long> ExcludedSubMerchantMemberIds { get; set; }
    }
}