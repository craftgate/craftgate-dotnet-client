using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request.Dto
{
    public class MasterpassCreatePayment
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public string PosAlias { get; set; }
        public int? Installment { get; set; }
        public Currency? Currency { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public string PaymentChannel { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
        public long? BuyerMemberId { get; set; }
        public string BankOrderId { get; set; }
        public string ClientIp { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}