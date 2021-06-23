namespace Craftgate.Request
{
    public class PostAuthPaymentRequest
    {
        public long PaymentId { get; set; }
        public decimal? PaidPrice { get; set; }
    }
}