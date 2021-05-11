using Craftgate.Response.Common;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class ReportingPaymentTransactionRefundResponse : BasePaymentTransactionRefundResponse
    {
        public string PaymentType { get; set; }
        public PaymentError Error { get; set; }
    }
}