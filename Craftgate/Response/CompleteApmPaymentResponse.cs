using Craftgate.Model;

namespace Craftgate.Response
{
    public class CompleteApmPaymentResponse
    {
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}