namespace Craftgate.Response.Dto
{
    public class WalletTransaction
    {
        public long Id { get; set; }
        public string WalletTransactionType { get; set; }
        public decimal Amount { get; set; }
        public long WalletId { get; set; }
    }
}