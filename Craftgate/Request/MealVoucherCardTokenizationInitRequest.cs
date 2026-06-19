using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class MealVoucherCardTokenizationInitRequest
    {
        public ApmType ApmType { get; set; }
        public MealVoucherCardTokenizationData MealVoucherCardTokenizationData { get; set; }
    }
}
