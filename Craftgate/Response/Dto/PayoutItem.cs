using System;

namespace Craftgate.Response.Dto
{
    public class PayoutItem
    {
        public string Subject { get; set; }
        public long SubjectId { get; set; }
        public string MerchantType { get; set; }
        public long MerchantId { get; set; }
        public decimal PayoutAmount { get; set; }
        public string Currency { get; set; }
        public string PayoutStatus { get; set; }
        public DateTime? PayoutDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}