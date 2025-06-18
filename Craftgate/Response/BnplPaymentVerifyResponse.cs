using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class BnplPaymentVerifyResponse
    {
        public PaymentStatus PaymentStatus { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public PaymentError PaymentError { get; set; }
    }
}