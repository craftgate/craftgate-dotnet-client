namespace Craftgate.Request.Dto
{
    public class FraudCheckParameters
    {
        public string BuyerExternalId { get; set; }
        public string BuyerGsmNumber { get; set; }
        public string BuyerEmail { get; set; }
    }
}