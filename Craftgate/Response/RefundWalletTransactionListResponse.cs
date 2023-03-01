using System.Collections.Generic;

namespace Craftgate.Response
{
    public class RefundWalletTransactionListResponse
    {
        public IList<RefundWalletTransactionResponse> Items { get; set; }
    }
}