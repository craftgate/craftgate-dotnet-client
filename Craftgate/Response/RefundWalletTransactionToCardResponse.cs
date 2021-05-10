using System;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class RefundWalletTransactionToCardResponse
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RefundStatus { get; set; }
        public decimal RefundPrice { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public long TransactionId { get; set; }
        public long WalletTransactionId { get; set; }
        public PaymentError PaymentError { get; set; }
        public string TransactionType { get; set; }
    }
}