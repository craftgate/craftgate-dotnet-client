using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class InstallmentSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Retrieve_Bin()
        {
            var binNumber = "525864";

            var response = _craftgateClient.Installment().RetrieveBinNumber(binNumber);
            Assert.NotNull(response);
            Assert.AreEqual(binNumber, response.BinNumber);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual("YAPI VE KREDİ BANKASI A.Ş.", response.BankName);
            Assert.AreEqual(67L, response.BankCode);
            Assert.AreEqual(false, response.Commercial);
        }

        [Test]
        public void Search_Installments()
        {
            var request = new SearchInstallmentsRequest
            {
                BinNumber = "525864",
                Price = 100,
                Currency = Currency.Try
            };

            var response = _craftgateClient.Installment().SearchInstallments(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Installments_With_Distinct_Card_Brand_With_Lowest_Commissions()
        {
            var request = new SearchInstallmentsRequest
            {
                BinNumber = "525864",
                Price = 100,
                Currency = Currency.Try,
                DistinctCardBrandsWithLowestCommissions = true
            };

            var response = _craftgateClient.Installment().SearchInstallments(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}