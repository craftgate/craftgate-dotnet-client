using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CancelWithdrawRequest : BaseRequest
    {
        public long? WithdrawId { get; set; }
    }
}
