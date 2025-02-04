using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class BnplPaymentOfferRequest
    {
        public ApmType ApmType { get; set; }
        public long? MerchantApmId { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
        public IList<BnplPaymentCartItem> Items;
    }
}