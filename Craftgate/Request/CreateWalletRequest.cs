using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CreateWalletRequest : BaseRequest
    {
        public decimal? NegativeAmountLimit { get; set; }
        public Currency Currency { get; set; }
    }
}