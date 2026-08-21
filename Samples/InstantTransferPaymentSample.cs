using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using Craftgate.Response;
using Craftgate.Response.Dto;
using NUnit.Framework;

namespace Samples
{
    public class InstantTransferPaymentSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key",
                "https://sandbox-api.craftgate.io");

        [Test]
        public void RetrieveActiveBanks()
        {
            CompayBanksResponse response = _craftgateClient.Payment().RetrieveActiveBanks();
            Assert.NotNull(response.Items);
            CompayBank compayBank = response.Items[0];
            Assert.NotNull(compayBank);
        }


        [Test]
        public void Init_Compay_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.COMPAY,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                AdditionalParams = new Dictionary<string, object>
                {
                    {"bankCode", "0"},
                    {"shopUrl", "your-website.com"},
                    {"receiptDescription", "your-description"}
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.40)
                    },

                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.60)
                    }
                }
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.HtmlContent);
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.SHOW_HTML_CONTENT);
        }

    }
}