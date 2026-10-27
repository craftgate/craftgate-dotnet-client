using System;

namespace Craftgate.Response.Dto
{
    public class PayoutCompletedItem
    {
        public long SettlementRowId { get; set; }
        public long SettlementFileId { get; set; }
        public string Subject { get; set; }
        public long SubjectId { get; set; }
        public long? PaymentTransactionId { get; set; }
        public string MerchantType { get; set; }
        public long MerchantId { get; set; }
        public decimal PayoutAmount { get; set; }
        public string Currency { get; set; }
        public DateTime? PayoutDate { get; set; }
        public string SettlementEarningsDestination { get; set; }
        public string SettlementSource { get; set; }
    }
}