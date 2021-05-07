using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class PayoutStatus
    {
        public TransactionPayoutStatus MerchantStatus { get; set; }
        public DateTime MerchantStatusDate { get; set; }
        public TransactionPayoutStatus SubMerchantMemberStatus { get; set; }
        public DateTime SubMerchantMemberStatusDate { get; set; }
    }
}