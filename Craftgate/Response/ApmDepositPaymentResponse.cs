using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class ApmDepositPaymentResponse
    {
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public string RedirectUrl { get; set; }
        public PaymentError PaymentError { get; set; }
        public WalletTransaction WalletTransaction { get; set; }
    }
}