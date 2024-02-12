using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitJuzdanPaymentRequest
    {
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public Currency Currency { get; set; }
        public PaymentGroup PaymentGroup { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl;
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
        public string PaymentChannel { get; set; }
        public long? BuyerMemberId { get; set; }
        public string BankOrderId { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public long? LoanCampaignId { get; set; }
        public long? MerchantId { get; set; }
        public ClientType ClientType { get; set; }
    }
}