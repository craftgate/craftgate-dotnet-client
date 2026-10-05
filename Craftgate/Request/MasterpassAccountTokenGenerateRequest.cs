using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class MasterpassAccountTokenGenerateRequest : BaseRequest
    {
        public string Msisdn { get; set; }
        public string UserId { get; set; }
    }
}
