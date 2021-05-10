namespace Craftgate.Response.Dto
{
    public class PayoutCompletedTransaction
    {
        public long TransactionId;
        public string TransactionType;
        public decimal PayoutAmount;
        public string Currency;
        public long MerchantId;
        public string MerchantType;
        public string SettlementEarningsDestination;
        public string SettlementSource;
    }
}