using Craftgate;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class BkmExpressSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Generate_Token()
        {
            var request = new BkmExpressGenerateTokenRequest()
            {
               GsmNumber = "5555555555",
               UserId = "user-id"
            };

            var response = _craftgateClient.BkmExpress().GenerateToken(request);
            Assert.NotNull(response);
        }
    }
}