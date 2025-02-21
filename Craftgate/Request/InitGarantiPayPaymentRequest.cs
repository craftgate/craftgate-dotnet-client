using System;
using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitGarantiPayPaymentRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public Currency? Currency { get; set; }
        public string PosAlias { get; set; }
        public PaymentGroup PaymentGroup { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public string ClientIp { get; set; }
        public string PaymentChannel { get; set; }
        public long? BuyerMemberId { get; set; }
        public string BankOrderId { get; set; }
        public IList<PaymentItem> Items { get; set; }
        public List<GarantiPayInstallment> Installments { get; set; }
        public IList<int> EnabledInstallments { get; set; }
    }
}