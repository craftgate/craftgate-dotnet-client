namespace Craftgate.Response
{
    public class PayoutAccountResponse
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string ExternalAccountId { get; set; }
        public string Currency { get; set; }
        public string AccountOwner { get; set; }
        public long? SubMerchantMemberId { get; set; }
    }
}