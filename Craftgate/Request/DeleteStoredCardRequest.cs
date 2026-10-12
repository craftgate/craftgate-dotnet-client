using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class DeleteStoredCardRequest : BaseRequest
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}