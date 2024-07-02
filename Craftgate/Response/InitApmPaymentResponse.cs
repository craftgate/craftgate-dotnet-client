using System;
using System.Collections.Generic;
using System.Text;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class InitApmPaymentResponse
    {
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public string RedirectUrl { get; set; }
        public string HtmlContent { get; set; }
        public PaymentError PaymentError { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
    }
}