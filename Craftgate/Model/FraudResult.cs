namespace Craftgate.Model
{
    public class FraudResult
    {
        public long Id { get; set; }
        public double? Score { get; set; }
        public FraudAction Action { get; set; }
    }
}