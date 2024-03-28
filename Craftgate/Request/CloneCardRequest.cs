namespace Craftgate.Request
{
    public class CloneCardRequest
    {
        public string SourceCardUserKey { get; set; }
        public string SourceCardToken { get; set; }
        public string TargetCardUserKey { get; set; }
        public long TargetMerchantId { get; set; }
    }
}