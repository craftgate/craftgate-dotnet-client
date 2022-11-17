using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class ProductResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrderId { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public Status Status { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public int Stock { get; set; }
        public int SoldCount { get; set; }
        public string Token { get; set; }
        public ISet<long> EnabledInstallments { get; set; }
        public string Url { get; set; }
        public string QrCodeUrl { get; set; }
        public string Channel { get; set; }
    }
}