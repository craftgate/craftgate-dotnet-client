namespace Craftgate.Response.Dto
{
    public class SettlementRowItem
    {
        public string Subject { get; set; }
        public long SubjectId { get; set; }
        public long? PaymentTransactionId { get; set; }
        public decimal PayoutAmount { get; set; }
    }
}