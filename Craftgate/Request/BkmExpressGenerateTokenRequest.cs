using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class BkmExpressGenerateTokenRequest : BaseRequest
    {
        public string GsmNumber { get; set; }
        public string UserId { get; set; }
    }
}