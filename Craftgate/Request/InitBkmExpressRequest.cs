using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
     public class InitBkmExpressRequest
     {
         public decimal? Price { get; set; }
         public decimal? PaidPrice { get; set; }
         public Currency? Currency { get; set; }
         public PaymentGroup? PaymentGroup { get; set; }
         public string ConversationId { get; set; }
         public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.AUTH;
         public long? BuyerMemberId { get; set; }
         public string BankOrderId { get; set; }
         public IList<PaymentItem> Items { get; set; }
         public IList<int> EnabledInstallments { get; set; }
     }
}