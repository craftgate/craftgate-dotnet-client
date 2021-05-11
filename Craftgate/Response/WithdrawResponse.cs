using System;

namespace Craftgate.Response
{
    public class WithdrawResponse
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public long MemberId { get; set; }
        public long? PayoutId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string PayoutStatus { get; set; }
    }
}