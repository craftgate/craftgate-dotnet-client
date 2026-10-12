using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class MealVoucherCardTokenizationCompleteRequest : BaseRequest
    {
        public string ValidationCode { get; set; }
    }
}
