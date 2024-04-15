using System;
using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class MultiPaymentResponse
    {
        public long Id { get; set; }
        public MultiPaymentStatus MultiPaymentStatus { get; set; }
        public string Token { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTime TokenExpireDate { get; set; }
        public ISet<long> PaymentIds { get; set; }
    }
}