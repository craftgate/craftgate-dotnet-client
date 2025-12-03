using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchProductsRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string OrderId { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public Currency? Currency { get; set; }
        public string Channel { get; set; }
        public DateTime MinExpiresAt { get; set; }
        public DateTime MaxExpiresAt { get; set; }

        public int? Page { get; set; } = 0;
        public int? Size { get; set; } = 25;
    }
}