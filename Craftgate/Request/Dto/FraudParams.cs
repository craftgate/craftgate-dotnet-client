namespace Craftgate.Request.Dto
{
    public class FraudParams
    {
        public string BuyerExternalId { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerEmail { get; set; }
        public string CustomFraudVariable { get; set; }
    }
}