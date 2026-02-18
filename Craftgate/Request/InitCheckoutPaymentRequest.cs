using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitCheckoutPaymentRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public string CallbackUrl { get; set; }
        public string CardUserKey { get; set; }
        public Currency? Currency { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public string PaymentChannel { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string OrderId { get; set; }
        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
        public IList<PaymentMethod> EnabledPaymentMethods { get; set; }
        public string MasterpassGsmNumber { get; set; }
        public string MasterpassUserId { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ClientIp { get; set; }
        public IList<int> EnabledInstallments { get; set; }
        public bool AlwaysStoreCardAfterPayment { get; set; }
        public bool AllowOnlyStoredCards { get; set; }
        public bool AllowOnlyCreditCard { get; set; }
        public bool AllowInstallmentOnlyCommercialCards { get; set; }
        public bool ForceThreeDS { get; set; }
        public bool ForceAuthForNonCreditCards { get; set; }
        public bool DepositPayment { get; set; }
        public string ReturnBackUrl { get; set; }
        public long? Ttl { get; set; }
        public IList<CustomInstallment> CustomInstallments { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public FraudCheckParameters FraudParams { get; set; }
        public Dictionary<string, object> AdditionalParams { get; set; }
        public Dictionary<string, List<CustomInstallment>> CardBrandInstallments { get; set; }
    }
}