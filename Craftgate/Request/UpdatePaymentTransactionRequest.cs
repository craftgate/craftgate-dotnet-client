namespace Craftgate.Request
{
    public class UpdatePaymentTransactionRequest
    {
        public long SubMerchantMemberId { get; set; }
        public decimal SubMerchantMemberPrice { get; set; }
        public decimal SubMerchantMemberTaxPrice { get; set; }
        public long PaymentTransactionId { get; set; }
    }
}