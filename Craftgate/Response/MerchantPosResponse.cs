using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class MerchantPosResponse
    {
        public long Id { get; set; }
        public PosStatus Status { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public PosIntegrator PosIntegrator { get; set; }
        public string Hostname { get; set; }
        public string ClientId { get; set; }
        public string PosCurrencyCode { get; set; }
        public string Mode { get; set; }
        public string Path { get; set; }
        public int Port { get; set; }
        public string PosnetId { get; set; }
        public string TerminalId { get; set; }
        public string ThreedsPosnetId { get; set; }
        public string ThreedsTerminalId { get; set; }
        public string ThreedsKey { get; set; }
        public string ThreedsPath { get; set; }
        public bool EnableForeignCard { get; set; }
        public bool EnableInstallment { get; set; }
        public bool EnablePaymentWithoutCvc { get; set; }
        public bool EnableLoyalty { get; set; }
        public bool NewIntegration { get; set; }
        public int OrderNumber { get; set; }
        public AutopilotState AutopilotState { get; set; }
        public Currency Currency { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public bool IsPf { get; set; }
        public List<MerchantPosUser> MerchantPosUsers { get; set; }
        public List<CardAssociation> SupportedCardAssociations { get; set; }
        public List<PaymentAuthenticationType> EnabledPaymentAuthenticationTypes { get; set; }
    }
}