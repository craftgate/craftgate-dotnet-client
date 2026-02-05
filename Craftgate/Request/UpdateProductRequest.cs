using System;
using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateProductRequest
    {
        public Status Status { get; set; }
        public string Name { get; set; }
        public string Channel { get; set; }
        public string OrderId { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Currency Currency { get; set; }
        public string Description { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool MultiPayment { get; set; }
        public ISet<long> EnabledInstallments { get; set; }
        public string BasketIdentifier { get; set; }
    }
}