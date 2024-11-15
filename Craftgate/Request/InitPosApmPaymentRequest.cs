using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitPosApmPaymentRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public string PosAlias { get; set; }
        public Currency? Currency { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
        public string PaymentChannel { get; set; }
        public long? BuyerMemberId { get; set; }
        public string BankOrderId { get; set; }
        public string ClientIp { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
        public List<PosApmInstallment> Installments { get; set; }
        public PosApmPaymentProvider? PaymentProvider { get; set; }
        public FraudCheckParameters FraudParams { get; set; }
        public string CheckoutFormToken { get; set; }
    }
}