using System.Collections.Generic;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class InitBnplPaymentRequest : InitApmPaymentRequest
    {
        public string BankCode { get; set; }
        public IList<BnplPaymentCartItem> CartItems;
    }
}