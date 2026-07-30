using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RefundWalletTransactionRequest : BaseRequest
    {
        public decimal RefundPrice { get; set; }
    }
}