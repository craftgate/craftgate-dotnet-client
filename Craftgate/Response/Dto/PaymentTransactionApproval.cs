using Craftgate.Model;

namespace Craftgate.Response
{
    public class PaymentTransactionApproval
    {
        public long? PaymentTransactionId { get; set; }
        public ApprovalStatus? ApprovalStatus { get; set; }
        public string FailedReason { get; set; }
    }
}