namespace Craftgate.Response
{
    public class PaymentTransactionApproval
    {
        public long? PaymentTransactionId { get; set; }
        public string ApprovalStatus { get; set; }
        public string FailedReason { get; set; }
    }
}