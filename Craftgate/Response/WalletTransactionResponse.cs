using System;

namespace Craftgate.Response
{
    public class WalletTransactionResponse
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string WalletTransactionType { get; set; }
        public decimal Amount { get; set; }
        public long TransactionId { get; set; }
        public long WalletId { get; set; }
    }
}