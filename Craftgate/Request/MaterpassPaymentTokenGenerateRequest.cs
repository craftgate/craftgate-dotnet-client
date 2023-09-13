using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class MasterpassPaymentTokenGenerateRequest
    {
        public string Msisdn { get; set; }
        public string UserId { get; set; }
        public string BinNumber { get; set; }
        public bool ForceThreeDS { get; set; }
        public MasterpassCreatePayment CreatePayment { get; set; }
    }
}