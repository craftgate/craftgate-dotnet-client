namespace Craftgate.Response
{
    public class MealVoucherCardTokenizationCompleteResponse
    {
        public string SessionId { get; set; }
        public string MaskedCardNumber { get; set; }
        public string Fingerprint { get; set; }
        public decimal? Balance { get; set; }
    }
}
