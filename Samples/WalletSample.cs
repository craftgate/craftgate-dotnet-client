using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class WalletSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Search_Wallets()
        {
            var request = new SearchWalletsRequest()
            {
                MemberId = 1L
            };

            var response = _craftgateClient.Wallet().SearchWallets(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Wallet_Transactions()
        {
            long walletId = 1;
            var request = new SearchWalletTransactionsRequest
            {
            };

            var response = _craftgateClient.Wallet().SearchWalletTransactions(walletId, request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Send_Remittance()
        {
            long memberId = 1;
            decimal price = new decimal(50.0);
            var request = new CreateRemittanceRequest
            {
                MemberId = memberId,
                Price = price,
                Description = "Remittance send to memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.Remittance
            };

            var response = _craftgateClient.Wallet().SendRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual(RemittanceType.Send, response.RemittanceType);
            Assert.AreEqual(RemittanceReasonType.Remittance, response.RemittanceReasonType);
        }

        [Test]
        public void Receive_Remittance()
        {
            long memberId = 1;
            decimal price = new decimal(50.0);
            var request = new CreateRemittanceRequest
            {
                MemberId = memberId,
                Price = price,
                Description = "Remittance received from memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.Remittance
            };

            var response = _craftgateClient.Wallet().ReceiveRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual(RemittanceType.Receive, response.RemittanceType);
            Assert.AreEqual(RemittanceReasonType.Remittance, response.RemittanceReasonType);
        }
    }
}