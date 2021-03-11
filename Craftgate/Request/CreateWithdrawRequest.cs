using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateWithdrawRequest
    {
        public decimal Price { get; set; }
        public long MemberId { get; set; }
        public string Description { get; set; }
        public Currency Currency { get; set; }
    }
}