using System;
using System.Text;

namespace Craftgate.Response
{
    public class InitApmPaymentResponse
    {
        public long PaymentId { get; set; }
        public string RedirectUrl { get; set; }
    }
}