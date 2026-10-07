using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class ResetMerchantMemberWalletBalanceRequest : BaseRequest
    {
        public decimal WalletAmount { get; set; }
    }
}