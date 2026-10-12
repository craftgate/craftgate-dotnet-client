using System;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CreatePayoutAccountRequest : BaseRequest
    {
        public PayoutAccountType Type { get; set; }
        public string ExternalAccountId { get; set; }
        public Currency Currency { get; set; }
        public AccountOwner AccountOwner { get; set; }
        public long? SubMerchantMemberId { get; set; }
    }
}