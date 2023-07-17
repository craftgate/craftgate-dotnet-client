using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdatePayoutAccountRequest
    {
        public PayoutAccountType Type { get; set; }
        public string ExternalAccountId { get; set; }
    }
}