using System;

namespace Craftgate.Response
{
    public class WalletResponse
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public long MemberId { get; set; }
    }
}