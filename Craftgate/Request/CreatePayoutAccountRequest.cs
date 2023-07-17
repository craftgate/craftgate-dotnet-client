using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreatePayoutAccountRequest
    {
        public PayoutAccountType Type { get; set; }
        public string ExternalAccountId { get; set; }
        public Currency Currency { get; set; }
        public AccountOwner AccountOwner { get; set; }
        public long? SubMerchantMemberId { get; set; }
    }
}