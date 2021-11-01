using System;
using Craftgate.Response.Dto;

namespace Craftgate.Response.Common
{
    public class BasePaymentResponse
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal WalletPrice { get; set; }
        public string Currency { get; set; }
        public long BuyerMemberId { get; set; }
        public int Installment { get; set; }
        public string ConversationId { get; set; }
        public string ExternalId { get; set; }
        public string PaymentType { get; set; }
        public string PaymentGroup { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentPhase { get; set; }
        public bool IsThreeDS { get; set; }
        public decimal MerchantCommissionRate { get; set; }
        public decimal MerchantCommissionRateAmount { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal BankCommissionRateAmount { get; set; }
        public bool PaidWithStoredCard { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public string OrderId { get; set; }
        public string CardHolderName { get; set; }
        public string BankCardHolderName { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public MerchantPos Pos { get; set; }
        public PaymentError PaymentError { get; set; }
    }
}