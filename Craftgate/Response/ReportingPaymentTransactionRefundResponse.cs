using Craftgate.Model;
using Craftgate.Response.Common;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class ReportingPaymentTransactionRefundResponse : BasePaymentTransactionRefundResponse
    {
        public PaymentType PaymentType { get; set; }
        public PaymentError Error { get; set; }
    }
}