using System;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class DepositPaymentResponse
    {
        public long? Id { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public long? BuyerMemberId { get; set; }
        public string ConversationId { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal BankCommissionRateAmount { get; set; }
        public string TransId { get; set; }
        public string OrderId { get; set; }
        public string PaymentType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PaymentStatus { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public WalletTransaction WalletTransaction { get; set; }
        public long? FraudId { get; set; }
        public FraudAction? FraudAction { get; set; }
    }
}