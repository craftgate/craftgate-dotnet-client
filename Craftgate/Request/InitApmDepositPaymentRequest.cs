using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitApmDepositPaymentRequest
    {
        public ApmType ApmType { get; set; }
        public long? MerchantApmId { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public long? BuyerMemberId { get; set; }
        public string PaymentChannel { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public string ApmOrderId { get; set; }
        public string ApmUserIdentity { get; set; }
        public Dictionary<string, string> AdditionalParams { get; set; }
        public string ClientIp { get; set; }
    }
}