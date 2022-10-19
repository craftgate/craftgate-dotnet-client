using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class CreateApmPaymentRequest
    {
        public ApmType ApmType { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public Currency Currency { get; set; }
        public PaymentGroup PaymentGroup { get; set; }
        public string PaymentChannel { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ApmOrderId { get; set; }
        public string ClientIp { get; set; }
        public IList<PaymentItem> Items { get; set; }
    }
}