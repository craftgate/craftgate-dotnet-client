using System;
using System.Text;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class InitApmPaymentResponse
    {
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public string RedirectUrl { get; set; }
    }
}