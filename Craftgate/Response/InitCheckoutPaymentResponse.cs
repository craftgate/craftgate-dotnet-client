using System;

namespace Craftgate.Response
{
    public class InitCheckoutPaymentResponse
    {
        public string Token { get; set; }
        public string PageUrl { get; set; }
        public DateTime TokenExpireDate { get; set; }
    }
}