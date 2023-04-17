using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Response;
using NUnit.Framework;

namespace Samples
{
    public class SettlementSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Instant_Wallet_Settlement()
        {
            var request = new CreateInstantWalletSettlementRequest();

            SettlementResponse response = _craftgateClient.Settlement().CreateInstantWalletSettlement(request);
            Assert.NotNull(response.SettlementResultStatus);
        }

        [Test]
        public void Search_Settlement_Rows()
        {
            var request = new SearchSettlementRowsRequest()
            {
                Page = 0,
                Size = 10,
                FileStatus = FileStatus.CREATED
            };

            var response = _craftgateClient.Settlement().SearchSettlementRows(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}