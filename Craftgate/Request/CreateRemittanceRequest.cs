using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CreateRemittanceRequest : BaseRequest
    {
        public long? MemberId { get; set; }
        public decimal? Price { get; set; }
        public Currency Currency { get; set; }
        public string Description { get; set; }
        public RemittanceReasonType? RemittanceReasonType { get; set; }
    }
}