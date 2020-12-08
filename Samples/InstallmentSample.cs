using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class InstallmentSample
    {
        private readonly Craftgate.Craftgate _craftgate =
            new Craftgate.Craftgate("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Retrieve_Bin()
        {
            var binNumber = "525864";

            var response = _craftgate.Installment().RetrieveBinNumber(binNumber);
            Assert.NotNull(response);
            Assert.AreEqual(response.BinNumber, binNumber);
            Assert.AreEqual(response.CardType, CardType.CreditCard);
            Assert.AreEqual(response.CardAssociation, CardAssociation.MasterCard);
            Assert.AreEqual(response.CardBrand, "World");
            Assert.AreEqual(response.BankName, "YAPI VE KREDİ BANKASI A.Ş.");
            Assert.AreEqual(response.BankCode, 67L);
            Assert.AreEqual(response.Commercial, false);
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

            var response = _craftgate.Installment().SearchInstallments(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}