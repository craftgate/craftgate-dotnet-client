namespace Craftgate.Response.Dto
{
    public class FraudValue
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? ExpireInSeconds { get; set; }
    }
}