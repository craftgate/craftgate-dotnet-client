using Craftgate;
using Craftgate.Model;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class HookSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Verify_Webhook()
        {
            string merchantHookKey = "Aoh7tReTybO6wOjBmOJFFsOR53SBojEp";
            string incomingSignature = "0wRB5XqWJxwwPbn5Z9TcbHh8EGYFufSYTsRMB74N094=";

            WebhookData webhookData = new WebhookData
            {
                EventType = WebhookEventType.API_VERIFY_AND_AUTH,
                EventTimestamp = 1661521221,
                Status = WebhookStatus.SUCCESS,
                PayloadId = "584",
            };

            var isVerified = _craftgateClient.Hook().IsWebhookVerified(merchantHookKey, incomingSignature, webhookData);
            Assert.True(isVerified);
        }
        
        [Test]
        public void Not_Verify_Webhook()
        {
            string merchantHookKey = "Aoh7tReTybO6wOjBmOJFFsOR53SBojEp";
            string incomingSignature = "Bsa498wcnaasd4bhx8anxıxcsdnxanalkdjcahxhd";

            WebhookData webhookData = new WebhookData
            {
                EventType = WebhookEventType.API_VERIFY_AND_AUTH,
                EventTimestamp = 1661521221,
                Status = WebhookStatus.SUCCESS,
                PayloadId = "584",
            };

            var isVerified = _craftgateClient.Hook().IsWebhookVerified(merchantHookKey, incomingSignature, webhookData);
            Assert.False(isVerified);
        }
    }
}