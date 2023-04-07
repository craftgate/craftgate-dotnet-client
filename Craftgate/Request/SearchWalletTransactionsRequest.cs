using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchWalletTransactionsRequest
    {
        public WalletTransactionType? WalletTransactionType { set; get; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}