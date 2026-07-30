using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class UpdateWalletRequest : BaseRequest
    {
        public decimal NegativeAmountLimit { get; set; }
    }
}