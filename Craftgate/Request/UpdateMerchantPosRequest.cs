using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateMerchantPosRequest
    {
        public string Name { get; set; }
        public string Hostname { get; set; }
        public string ClientId { get; set; }
        public string Mode { get; set; }
        public string Path { get; set; }
        public int? Port { get; set; }
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
        public IList<CardAssociation> SupportedCardAssociations { get; set; }
        public IList<PaymentAuthenticationType> EnabledPaymentAuthenticationTypes { get; set; }
        public IList<UpdateMerchantPosUser> MerchantPosUsers { get; set; }
    }
}