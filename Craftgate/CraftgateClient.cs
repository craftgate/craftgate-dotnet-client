using Craftgate.Adapter;
using Craftgate.Request.Common;

namespace Craftgate
{
    public class CraftgateClient
    {
        private const string BaseUrl = "https://api.craftgate.io";
        private readonly FileReportingAdapter _fileReportingAdapter;
        private readonly FraudAdapter _fraudAdapter;
        private readonly InstallmentAdapter _installmentAdapter;
        private readonly OnboardingAdapter _onboardingAdapter;
        private readonly PayByLinkApiAdapter _payByLinkApiAdapter;
        private readonly PaymentAdapter _paymentAdapter;
        private readonly PaymentReportingAdapter _paymentReportingAdapter;
        private readonly SettlementAdapter _settlementAdapter;
        private readonly SettlementReportingAdapter _settlementReportingAdapter;
        private readonly WalletAdapter _walletAdapter;

        public CraftgateClient(string apiKey, string secretKey)
            : this(apiKey, secretKey, BaseUrl, null)
        {
        }

        public CraftgateClient(string apiKey, string secretKey, string baseUrl)
            : this(apiKey, secretKey, baseUrl, null)
        {
        }
        
        public CraftgateClient(string apiKey, string secretKey, string baseUrl, string language)
        {
            var requestOptions = new RequestOptions
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
                BaseUrl = baseUrl,
                Language = language
            };

            _installmentAdapter = new InstallmentAdapter(requestOptions);
            _onboardingAdapter = new OnboardingAdapter(requestOptions);
            _paymentAdapter = new PaymentAdapter(requestOptions);
            _paymentReportingAdapter = new PaymentReportingAdapter(requestOptions);
            _walletAdapter = new WalletAdapter(requestOptions);
            _settlementAdapter = new SettlementAdapter(requestOptions);
            _settlementReportingAdapter = new SettlementReportingAdapter(requestOptions);
            _payByLinkApiAdapter = new PayByLinkApiAdapter(requestOptions);
            _fileReportingAdapter = new FileReportingAdapter(requestOptions);
            _fraudAdapter = new FraudAdapter(requestOptions);
        }

        public PaymentAdapter Payment()
        {
            return _paymentAdapter;
        }

        public PaymentReportingAdapter PaymentReporting()
        {
            return _paymentReportingAdapter;
        }

        public InstallmentAdapter Installment()
        {
            return _installmentAdapter;
        }

        public OnboardingAdapter Onboarding()
        {
            return _onboardingAdapter;
        }

        public WalletAdapter Wallet()
        {
            return _walletAdapter;
        }

        public SettlementAdapter Settlement()
        {
            return _settlementAdapter;
        }

        public SettlementReportingAdapter SettlementReporting()
        {
            return _settlementReportingAdapter;
        }

        public PayByLinkApiAdapter PayByLink()
        {
            return _payByLinkApiAdapter;
        }

        public FileReportingAdapter FileReporting()
        {
            return _fileReportingAdapter;
        }     
        
        public FraudAdapter Fraud()
        {
            return _fraudAdapter;
        }
    }
}