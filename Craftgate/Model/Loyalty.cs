namespace Craftgate.Model
{
    public class Loyalty
    {
        public LoyaltyType Type { get; set; }
        public Reward Reward { get; set; }
        public string Message { get; set; }
        public LoyaltyData LoyaltyData { get; set; }
        public LoyaltyParams LoyaltyParams { get; set; }
    }
}