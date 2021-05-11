using System;

namespace Craftgate.Response.Dto
{
    public class PayoutStatus
    {
        public string MerchantStatus { get; set; }
        public DateTime MerchantStatusDate { get; set; }
        public string SubMerchantMemberStatus { get; set; }
        public DateTime SubMerchantMemberStatusDate { get; set; }
    }
}