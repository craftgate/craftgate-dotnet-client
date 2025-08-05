using System;
using System.Text;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class InitThreeDSPaymentResponse
    {
        public string HtmlContent { get; set; }
        public long PaymentId { get; set; }
        public string RedirectUrl { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public AdditionalAction AdditionalAction { get; set; }

        public string GetDecodedHtmlContent()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(HtmlContent));
        }
    }
}