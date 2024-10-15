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
        private readonly HookAdapter _hookAdapter;
        private readonly MasterpassPaymentAdapter _masterpassPaymentAdapter;
        private readonly BankAccountTrackingAdapter _bankAccountTrackingAdapter;
        private readonly MerchantAdapter _merchantAdapter;
        private readonly MerchantApmAdapter _merchantApmAdapter;
        private readonly JuzdanPaymentAdapter _juzdanPaymentAdapter;
        private readonly BkmExpressPaymentAdapter _bkmExpressPaymentAdapter;

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
            _hookAdapter = new HookAdapter(requestOptions);
            _masterpassPaymentAdapter = new MasterpassPaymentAdapter(requestOptions);
            _bankAccountTrackingAdapter = new BankAccountTrackingAdapter(requestOptions);
            _merchantAdapter = new MerchantAdapter(requestOptions);
            _merchantApmAdapter = new MerchantApmAdapter(requestOptions);
            _juzdanPaymentAdapter = new JuzdanPaymentAdapter(requestOptions);
            _bkmExpressPaymentAdapter = new BkmExpressPaymentAdapter(requestOptions);
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

        public HookAdapter Hook()
        {
            return _hookAdapter;
        }
        
        public MasterpassPaymentAdapter Masterpass()
        {
            return _masterpassPaymentAdapter;
        }

        public BankAccountTrackingAdapter BankAccountTracking()
        {
            return _bankAccountTrackingAdapter;
        }
        
        public MerchantAdapter Merchant()
        {
            return _merchantAdapter;
        }

        public MerchantApmAdapter MerchantApm()
        {
            return _merchantApmAdapter;
        }

        public JuzdanPaymentAdapter Juzdan()
        {
            return _juzdanPaymentAdapter;
        }

        public BkmExpressPaymentAdapter BkmExpress()
        {
            return _bkmExpressPaymentAdapter;
        }
    }
}