using System;
using System.Text;

namespace Craftgate.Response
{
    public class InitGarantiPayPaymentResponse
    {
        public string HtmlContent { get; set; }

        public string GetDecodedHtmlContent()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(HtmlContent));
        }
    }
}