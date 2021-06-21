using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class CreatePaymentRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? WalletPrice { get; set; } = decimal.Zero;
        public string PosAlias { get; set; }
        public int? Installment { get; set; }
        public Currency? Currency { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.Auth;
        public long? BuyerMemberId { get; set; }
        public string ClientIp { get; set; }
        public Card Card { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}