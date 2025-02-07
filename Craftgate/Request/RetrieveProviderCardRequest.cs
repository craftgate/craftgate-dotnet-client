using Craftgate.Model;

namespace Craftgate.Request
{
    public class RetrieveProviderCardRequest
    {
        public string ProviderCardToken { get; set; }
        public string ExternalId { get; set; }
        public string ProviderCardUserId { get; set; }
        public string CardProvider { get; set; }
    }
}