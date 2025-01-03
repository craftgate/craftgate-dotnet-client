using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class BkmExpressSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");


        [Test]
        public void Init_Bkm_Express_Payment()
        {
            var request = new InitBkmExpressRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0)
                    }
                }
            };

            var response = _craftgateClient.BkmExpress().Init(request);
            Assert.NotNull(response);
        }

        [Test]
        public void Complete_Bkm_Express_Payment()
        {
            var request = new CompleteBkmExpressRequest()
            {
                Status = true,
                Message = "İşlem Başarılı",
                TicketId = "b9bd7b93-662f-4460-9ef3-8fc735853cf1",
            };


            var response = _craftgateClient.BkmExpress().Complete(request);
            Assert.NotNull(response.HostReference);
            Assert.NotNull(response);
        }

        [Test]
        public void Complete_Bkm_Express_Payment_By_Token()
        {
            var request = new CompleteBkmExpressRequest()
            {
                Status = true,
                Message = "İşlem Başarılı",
                TicketId = "7c0f7c89-e954-46d5-ad37-2a5c0b5f0356",
                BkmExpressPaymentToken = "23f4e147-2c4e-4a2c-8a67-9c783d813b79"
            };


            var response = _craftgateClient.BkmExpress().Complete(request);
            Assert.NotNull(response.HostReference);
            Assert.NotNull(response);
        }

        [Test]
        public void Retrieve_Payment()
        {
            var ticketId = "b9bd7b93-662f-4460-9ef3-8fc735853cf1";

            var response = _craftgateClient.BkmExpress().RetrievePayment(ticketId);
            Assert.NotNull(response);
        }

        [Test]
        public void Retrieve_Payment_By_Token()
        {
            var token = "23f4e147-2c4e-4a2c-8a67-9c783d813b79";

            var response = _craftgateClient.BkmExpress().RetrievePayment(token);
            Assert.NotNull(response);
        }
    }
}