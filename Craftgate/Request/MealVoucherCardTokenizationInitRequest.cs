using Craftgate.Model;
using Craftgate.Request.Common;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class MealVoucherCardTokenizationInitRequest : BaseRequest
    {
        public ApmType ApmType { get; set; }
        public MealVoucherCardTokenizationData MealVoucherCardTokenizationData { get; set; }
    }
}
