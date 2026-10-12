using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class UpdateMerchantPosStatusRequest : BaseRequest
    {
        public long? MerchantPosId { get; set; }
        public PosStatus? PosStatus { get; set; }
    }
}
