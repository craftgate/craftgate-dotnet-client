using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class MerchantApmSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Merchant_Apm()
        {
            var request = new CreateMerchantApmRequest()
            {
                Name = "my test apm",
                ApmType = ApmType.PAPARA,
                Hostname = "https://merchant-api.papara.com",
                SupportedCurrencies = new List<Currency> { Currency.TRY, Currency.USD, Currency.EUR, Currency.GBP },
                Properties = new Dictionary<string, object>
                 {
                     { "apiKey", "api-key-2" },
                     { "secretKey", "secret-key" }
                 }
            };

            var response = _craftgateClient.MerchantApm().CreateMerchantApm(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.ApmType, ApmType.PAPARA);
        }

        [Test]
        public void Retrieve_Merchant_Apm()
        {
            var response = _craftgateClient.MerchantApm().RetrieveMerchantApm();
            Assert.NotNull(response);
        }

        [Test]
        public void Update_Merchant_Apm()
        {
            const int id = 26;
            var request = new UpdateMerchantApmRequest()
            {
                Name = "my test apm update",
                Status = ApmStatus.ACTIVE,
                Hostname = "https://merchant-api.papara.com",
                SupportedCurrencies = new List<Currency> { Currency.TRY, Currency.USD, Currency.EUR, Currency.GBP },
                Properties = new Dictionary<string, object>
                 {
                     { "apiKey", "api-key-2" },
                     { "secretKey", "secret-key" }
                 }
            };

            var response = _craftgateClient.MerchantApm().UpdateMerchantApm(id, request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Name, "my test apm update");
        }


        [Test]
        public void Update_Merchant_Apm_Status()
        {
            const int id = 26;
            var request = new UpdateMerchantApmStatusRequest()
            {
                Status = ApmStatus.PASSIVE
            };

            _craftgateClient.MerchantApm().UpdateMerchantApmStatus(id, request);
        }

        [Test]
        public void Delete_Merchant_Apm()
        {
            const int id = 26;

            _craftgateClient.MerchantApm().DeleteMerchantApm(id);
        }
    }
}