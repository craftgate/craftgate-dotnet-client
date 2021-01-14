using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class WalletTransactionResponse
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public WalletTransactionType? WalletTransactionType { get; set; }
        public decimal Amount { get; set; }
        public long TransactionId { get; set; }
        public long WalletId { get; set; }
    }
}