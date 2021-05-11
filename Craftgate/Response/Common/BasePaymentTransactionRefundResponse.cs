using System;

namespace Craftgate.Response.Common
{
    public class BasePaymentTransactionRefundResponse
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string RefundDestinationType { get; set; }
        public decimal RefundPrice { get; set; }
        public decimal RefundBankPrice { get; set; }
        public decimal RefundWalletPrice { get; set; }
        public string ConversationId { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public bool IsAfterSettlement { get; set; }
        public long PaymentTransactionId { get; set; }
    }
}