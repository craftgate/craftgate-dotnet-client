using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchWalletTransactionsRequest
    {
        public WalletTransactionType? WalletTransactionType { set; get; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}