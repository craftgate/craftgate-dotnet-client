using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RetrieveProviderCardRequest : BaseRequest
    {
        public string ProviderCardToken { get; set; }
        public string ExternalId { get; set; }
        public string ProviderCardUserId { get; set; }
        public string CardProvider { get; set; }
    }
}