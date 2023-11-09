using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class MasterpassSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");
        

        [Test]
        public void Check_Masterpass_User()
        {
            var request = new CheckMasterpassUserRequest
            {
                MasterpassGsmNumber = "903000000000"
            };

            var response = _craftgateClient.Masterpass().CheckMasterpassUser(request);
            Assert.AreEqual(true, response.IsEligibleToUseMasterpass);
            Assert.NotNull(response);
        }
        
        [Test]
        public void Generate_Masterpass_Payment_Token()
        {
            var request = new MasterpassPaymentTokenGenerateRequest()
            {
                UserId = "masterpass-user-id",
                Msisdn = "900000000000",
                BinNumber = "404308",
                ForceThreeDS = false,
                CreatePayment = new MasterpassCreatePayment()
                {
                    Price = new decimal(100.0),
                    PaidPrice = new decimal(100.0),
                    Installment = 1,
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
                }
            };


            var response = _craftgateClient.Masterpass().GenerateMasterpassPaymentToken(request);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.ReferenceId);
            Assert.NotNull(response.OrderNo);
        }

        [Test]
        public void Complete_Masterpass_Payment_Token()
        {
            var request = new MasterpassPaymentCompleteRequest()
            {
                ReferenceId = "referenceId",
                Token = "Token"
            };

            var response = _craftgateClient.Masterpass().CompleteMasterpassPayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual("MASTERPASS", response.PaymentProvider);
        }

        [Test]
        public void Init_3DS_Masterpass_Payment()
        {
            var request = new MasterpassPaymentThreeDSInitRequest()
            {
                ReferenceId = "referenceId",
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback"
            };

            var response = _craftgateClient.Masterpass().Init3DSMasterpassPayment(request);
            Assert.NotNull(response.ReturnUrl);
        }

        [Test]
        public void Complete_3DS_Masterpass_Payment()
        {
            var request = new MasterpassPaymentThreeDSCompleteRequest()
            {
                PaymentId = 1,
            };

            var response = _craftgateClient.Masterpass().Complete3DSMasterpassPayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual("MASTERPASS", response.PaymentProvider);
        }
    }
}