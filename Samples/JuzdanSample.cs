using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class JuzdanSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Init()
        {
            var items = new List<PaymentItem>();
            var paymentItem = new PaymentItem()
            {
                Price = 0,
                Name = "test123",
                ExternalId = "test2"
            };

            items.Add(paymentItem);

            var initJuzdanPaymentRequest = new InitJuzdanPaymentRequest()
            {
                    Price = 0,
                    PaidPrice = 1,
                    Currency = Currency.TRY,
                    PaymentGroup = PaymentGroup.PRODUCT,
                    ConversationId = "testConversationId",
                    ExternalId = "testExternalId",
                    CallbackUrl = "www.testCallbackUrl.com",
                    ClientType = ClientType.W,
                    Items = items,
                    PaymentPhase = PaymentPhase.AUTH,
                    PaymentChannel = "testPaymentChannel",
                    BankOrderId = "testBankOrderId",
            };

            var initResponse = _craftgateClient.Juzdan().Init(initJuzdanPaymentRequest);

            Assert.NotNull(initResponse);
            Assert.NotNull(initResponse.JuzdanQrUrl);
            Assert.NotNull(initResponse.ReferenceId);
        }

        [Test]
        public void Retrieve() {
            var referenceId = "5493c7a7-4d8b-4517-887d-f8b8f826a3d0";

            var paymentResponse = _craftgateClient.Juzdan().Retrieve(referenceId);

            Assert.IsNotNull(paymentResponse);
            Assert.AreEqual(PaymentSource.JUZDAN, paymentResponse.PaymentSource);
            Assert.AreEqual(PaymentType.CARD_PAYMENT, paymentResponse.PaymentType);
        }

    }
}