using Craftgate.Request.Common;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class MealVoucherCardTokenizationRegenerateRequest : BaseRequest
    {
        public MealVoucherCardTokenizationData MealVoucherCardTokenizationData { get; set; }
    }
}
