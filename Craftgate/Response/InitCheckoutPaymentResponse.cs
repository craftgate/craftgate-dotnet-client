using System;
using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class InitCheckoutPaymentResponse
    {
        public string Token { get; set; }
        public string PageUrl { get; set; }
    }
}