using System;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class UpdatePaymentTransactionRequest : BaseRequest
    {
        public long? SubMerchantMemberId { get; set; }
        public decimal? SubMerchantMemberPrice { get; set; }
        public long PaymentTransactionId { get; set; }
        
        public DateTime? BlockageResolvedDate { get; set; }
    }
}