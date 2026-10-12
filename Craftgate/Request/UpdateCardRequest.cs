using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class UpdateCardRequest : BaseRequest
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string ExpireYear { get; set; }
        public string ExpireMonth { get; set; }
        public string CardAlias { get; set; }
    }
}