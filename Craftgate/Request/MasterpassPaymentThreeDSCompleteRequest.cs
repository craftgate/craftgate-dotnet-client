using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class MasterpassPaymentThreeDSCompleteRequest : BaseRequest
    {
        public long? PaymentId;
    }
}