using Craftgate.Response.Common;

namespace Craftgate.Response.Dto
{
    public class PaymentError
    {
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorGroup { get; set; }
        public ProviderError ProviderError { get; set; }
    }
}