using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class CompletePosApmPaymentResponse
    {
        public string ConversationId { get; set; }
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentError PaymentError { get; set; }
    }
}