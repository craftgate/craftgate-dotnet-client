using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class InitPosApmPaymentResponse
    {
        public string HtmlContent { get; set; }
        public long PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public AdditionalAction AdditionalAction { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
        public PaymentError PaymentError { get; set; }
    }
}