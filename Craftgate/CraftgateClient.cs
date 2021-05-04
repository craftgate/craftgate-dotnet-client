using System.Collections.Generic;
using Craftgate.Adapter;
using Craftgate.Request.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Craftgate
{
    public class CraftgateClient
    {
        private const string BaseUrl = "https://api.craftgate.io";
        private readonly InstallmentAdapter _installmentAdapter;
        private readonly OnboardingAdapter _onboardingAdapter;
        private readonly PaymentAdapter _paymentAdapter;
        private readonly WalletAdapter _walletAdapter;
        private readonly SettlementReportingAdapter _settlementReportingAdapter;
        private readonly SettlementAdapter _settlementAdapter;

        public CraftgateClient(string apiKey, string secretKey)
            : this(apiKey, secretKey, BaseUrl)
        {
        }

        public CraftgateClient(string apiKey, string secretKey, string baseUrl)
        {
            ConfigureJsonConverter();

            var requestOptions = new RequestOptions
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
                BaseUrl = baseUrl
            };

            _installmentAdapter = new InstallmentAdapter(requestOptions);
            _onboardingAdapter = new OnboardingAdapter(requestOptions);
            _paymentAdapter = new PaymentAdapter(requestOptions);
            _walletAdapter = new WalletAdapter(requestOptions);
            _settlementReportingAdapter = new SettlementReportingAdapter(requestOptions);
            _settlementAdapter = new SettlementAdapter(requestOptions);
        }

        public PaymentAdapter Payment()
        {
            return _paymentAdapter;
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

        public SettlementReportingAdapter SettlementReporting()
        {
            return _settlementReportingAdapter;
        }


        public SettlementAdapter Settlement()
        {
            return _settlementAdapter;
        }

        private static void ConfigureJsonConverter()
        {
            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter()
                    }
                };
                return settings;
            };
        }
    }
}