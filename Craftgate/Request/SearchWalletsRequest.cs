namespace Craftgate.Request
{
    public class SearchWalletsRequest
    {
        public long? MemberId { set; get; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}