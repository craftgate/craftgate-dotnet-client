using Craftgate.Model;

namespace Craftgate.Response
{
    public class MealVoucherCardTokenizationInitResponse
    {
        public string SessionId { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public string HtmlContent { get; set; }
        public string RedirectUrl { get; set; }
    }
}
