using System.Collections.Generic;

namespace Craftgate.Response
{
    public class RefundWalletTransactionToCardListResponse
    {
        public IList<RefundWalletTransactionToCardResponse> Items { get; set; }
    }
}