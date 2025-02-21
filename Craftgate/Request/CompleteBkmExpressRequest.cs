namespace Craftgate.Request
{
     public class CompleteBkmExpressRequest
     {
         public bool? Status { get; set; }
         public string Message { get; set; }
         public string TicketId { get; set; }
         public string BkmExpressPaymentToken { get; set; }

     }
}