using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class DeleteMerchantPosRequest : BaseRequest
    {
        public long? MerchantPosId { get; set; }
    }
}
