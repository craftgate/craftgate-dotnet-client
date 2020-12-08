using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class DeleteStoredCardRequest
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}