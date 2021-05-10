using Craftgate.Model;
using Craftgate.Response.Common;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class ReportingPaymentRefundResponse : BasePaymentRefundResponse
    {
        public PaymentType PaymentType { get; set; }
        public PaymentError Error { get; set; }
    }
}