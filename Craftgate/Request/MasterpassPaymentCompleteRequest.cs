using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class MasterpassPaymentCompleteRequest : BaseRequest
    {
        public string ReferenceId { get; set; }
        public string Token { get; set; }
    }
}