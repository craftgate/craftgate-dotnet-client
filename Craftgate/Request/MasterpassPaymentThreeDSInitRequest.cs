namespace Craftgate.Request
{
    public class MasterpassPaymentThreeDSInitRequest
    {
        public string ReferenceId { get; set; }
        public string CallbackUrl { get; set; }
    }
}