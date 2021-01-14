using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class WalletResponse
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public long MemberId { get; set; }
    }
}