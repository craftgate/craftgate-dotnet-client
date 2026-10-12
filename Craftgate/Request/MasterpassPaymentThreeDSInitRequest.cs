using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class MasterpassPaymentThreeDSInitRequest : BaseRequest
    {
        public string ReferenceId { get; set; }
        public string CallbackUrl { get; set; }
    }
}