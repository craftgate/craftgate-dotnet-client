using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateRemittanceRequest
    {
        public long? MemberId { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public RemittanceReasonType? RemittanceReasonType { get; set; }
    }
}