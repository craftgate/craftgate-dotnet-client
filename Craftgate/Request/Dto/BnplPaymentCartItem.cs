using Craftgate.Model;

namespace Craftgate.Request.Dto
{
    public class BnplPaymentCartItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public BnplCartItemType Type { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}