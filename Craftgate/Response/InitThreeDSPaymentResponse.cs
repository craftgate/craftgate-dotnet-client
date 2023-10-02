using System;
using System.Text;

namespace Craftgate.Response
{
    public class InitThreeDSPaymentResponse
    {
        public string HtmlContent { get; set; }
        public long PaymentId { get; set; }

        public string GetDecodedHtmlContent()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(HtmlContent));
        }
    }
}