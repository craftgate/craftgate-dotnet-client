using System.Collections.Generic;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CreateInstantWalletSettlementRequest : BaseRequest
    {
        public ISet<long> ExcludedSubMerchantMemberIds { get; set; }
    }
}