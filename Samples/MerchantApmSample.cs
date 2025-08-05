using Craftgate;
using NUnit.Framework;

namespace Samples
{
    public class MerchantApmSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");


        [Test]
        public void Retrieve_Apms()
        {

            var response = _craftgateClient.MerchantApm().RetrieveApms();
            Assert.True(response.Items.Count > 0);
        }
        
    }
}