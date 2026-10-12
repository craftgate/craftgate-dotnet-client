
namespace Craftgate.Request.Dto
{
    public class MealVoucherCardTokenizationData
    {
        public string CardNumber { get; set; }
        public string UserReferenceNumber { get; set; }
        public string GsmNumber { get; set; }
        public string CallbackUrl { get; set; }
    }
}
