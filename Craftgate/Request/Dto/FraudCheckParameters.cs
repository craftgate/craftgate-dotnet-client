namespace Craftgate.Request.Dto
{
    public class FraudCheckParameters
    {
        public string BuyerExternalId { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerEmail { get; set; }
    }
}