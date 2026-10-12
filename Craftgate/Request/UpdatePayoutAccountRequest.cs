using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class UpdatePayoutAccountRequest : BaseRequest
    {
        public PayoutAccountType Type { get; set; }
        public string ExternalAccountId { get; set; }
    }
}