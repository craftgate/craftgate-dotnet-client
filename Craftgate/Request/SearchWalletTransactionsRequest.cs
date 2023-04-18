using System;
using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchWalletTransactionsRequest
    {
        public ISet<WalletTransactionType> WalletTransactionTypes { set; get; }
        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}