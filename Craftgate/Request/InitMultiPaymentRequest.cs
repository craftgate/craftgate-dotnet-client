using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitMultiPaymentRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public Currency? Currency { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public PaymentSource? PaymentSource { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
        public string PaymentChannel { get; set; }
        public IList<PaymentMethod> EnabledPaymentMethods { get; set; }
        public string CardUserKey { get; set; }
        public long? BuyerMemberId { get; set; }
        public bool AllowOnlyCreditCard { get; set; }
        public bool ForceAuthForNonCreditCards { get; set; }
        public bool AllowOnlyStoredCards { get; set; }
        public bool AllowInstallmentOnlyCommercialCards { get; set; }
        public bool AlwaysStoreCardAfterPayment { get; set; }
        public bool DisableStoreCard { get; set; }
        public bool ForceThreeDS { set; get; }
        public string MasterpassGsmNumber { get; set; }
        public string MasterpassUserId { get; set; }
        public string ApmUserIdentity { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public long? Ttl { get; set; }
        public int MaximumSplitPaymentCount { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
    }
}