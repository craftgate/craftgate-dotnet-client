namespace Craftgate.Request
{
    public class ApplePayMerchantSessionCreateRequest
    {
        public string MerchantIdentifier { get; set; }
        public string DisplayName { get; set; }
        public string Initiative { get; set; }
        public string InitiativeContext { get; set; }
        public string ValidationUrl { get; set; }
    }
}