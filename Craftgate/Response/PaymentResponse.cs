using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Common;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PaymentResponse : BasePaymentResponse
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public long? FraudId { get; set; }
        public FraudAction? FraudAction { get; set; }
        public IList<PaymentTransaction> PaymentTransactions;
    }
}