using Craftgate.Request.Common;

namespace Craftgate.Request
{
     public class CompleteBkmExpressRequest : BaseRequest
     {
         public bool? Status { get; set; }
         public string Message { get; set; }
         public string TicketId { get; set; }
         public string BkmExpressPaymentToken { get; set; }

     }
}