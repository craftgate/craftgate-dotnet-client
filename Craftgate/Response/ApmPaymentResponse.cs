using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Common;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class ApmPaymentResponse : BasePaymentResponse
    {
        public ApmType ApmType { get; set; }
        public string TransactionId { get; set; }
        public string RedirectUrl { get; set; }
    }
}