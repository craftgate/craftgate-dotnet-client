using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateMerchantPosRequest
    {
        public PosStatus Status;
        public string Name;
        public string ClientId;
        public Currency Currency;
        public string PosnetId;
        public string TerminalId;
        public string ThreedsPosnetId;
        public string ThreedsTerminalId;
        public string ThreedsKey;
        public bool EnableForeignCard;
        public bool EnableInstallment;
        public bool EnablePaymentWithoutCvc;
        public bool NewIntegration;
        public int OrderNumber;
        public PosIntegrator PosIntegrator;
        public IList<PaymentAuthenticationType> EnabledPaymentAuthenticationTypes;
        public IList<CreateMerchantPosUser> MerchantPosUsers;
    }
}