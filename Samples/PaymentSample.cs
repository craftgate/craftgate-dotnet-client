using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class PaymentSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key",
                "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
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
                },
                FraudParams = new FraudCheckParameters()
                {
                    BuyerEmail = "test@test.com",
                    BuyerPhoneNumber = "5555555555",
                    BuyerExternalId = "buyerExternalId"
                }
            };

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("52586400", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
            Assert.Null(response.FraudId);
            Assert.Null(response.FraudAction);
        }

        [Test]
        public void Create_Marketplace_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.PRODUCT,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(18.0)
                    }
                }
            };

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("PRODUCT", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Create_Payment_And_Store_Card()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "external_id-123456789",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000",
                    StoreCardAfterSuccessPayment = true,
                    CardAlias = "My YKB Card"
                },
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

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(request.ConversationId, response.ConversationId);
            Assert.AreEqual(request.ExternalId, response.ExternalId);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.NotNull(response.CardUserKey);
            Assert.NotNull(response.CardToken);
        }

        [Test]
        public void Create_Payment_Using_Stored_Card()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardUserKey = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                    CardToken = "11a078c4-3c32-4796-90b1-51ee5517a212"
                },
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

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(true, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Create_Payment_Using_External_Payment_Provider_Stored_Card()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                PosAlias = "6007-posAlias-1",
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "external_id-123456789",
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
                },
                AdditionalParams = new Dictionary<string, object>
                {
                    {
                        "paymentProvider", new Dictionary<string, object>
                        {
                            { "cardUserKey", "test-cardUserKey" },
                            { "cardToken", "tuz8imxv30" }
                        }
                    }
                }
            };

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.BinNumber);
            Assert.Null(response.LastFourDigits);
            Assert.Null(response.CardType);
            Assert.Null(response.CardAssociation);
            Assert.Null(response.CardBrand);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Create_Payment_With_Loyalty()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "4043080000000003",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000",
                    Loyalty = new Loyalty
                    {
                        Type = LoyaltyType.REWARD_MONEY,
                        Reward = new Reward
                        {
                            CardRewardMoney = new decimal(1.36),
                            FirmRewardMoney = new decimal(3.88)
                        }
                    }
                },
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

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("404308", response.BinNumber);
            Assert.AreEqual("0003", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("VISA", response.CardAssociation);
            Assert.AreEqual("Bonus", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
            Assert.NotNull(response.Loyalty);
            Assert.AreEqual(LoyaltyType.REWARD_MONEY, response.Loyalty.Type);
            Assert.NotNull(response.Loyalty.Reward);
            Assert.AreEqual(new decimal(1.36), response.Loyalty.Reward.CardRewardMoney);
            Assert.AreEqual(new decimal(3.88), response.Loyalty.Reward.FirmRewardMoney);
        }

        [Test]
        public void Create_Payment_With_First6_Last4_and_IdentityNumber()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardHolderIdentityNumber = "12345678900",
                    BinNumber = "404308",
                    LastFourDigits = "0003"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(100.0)
                    }
                }
            };

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("404308", response.BinNumber);
            Assert.AreEqual("0003", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("VISA", response.CardAssociation);
            Assert.AreEqual("Bonus", response.CardBrand);
            Assert.AreEqual(1, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Init_3DS_Payment()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
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


            var response = _craftgateClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
        }

        [Test]
        public void Init_3DS_Marketplace_Payment()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.PRODUCT,
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantMemberId = 1,
                        SubMerchantMemberPrice = new decimal(18.0)
                    }
                }
            };

            var response = _craftgateClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
        }

        [Test]
        public void Init_3DS_Payment_And_Store_Card()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000",
                    StoreCardAfterSuccessPayment = true,
                    CardAlias = "My YKB Card"
                },
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

            var response = _craftgateClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
        }

        [Test]
        public void Init_3DS_Payment_Using_Stored_Card()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback",
                Card = new Card
                {
                    CardUserKey = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                    CardToken = "11a078c4-3c32-4796-90b1-51ee5517a212"
                },
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

            var response = _craftgateClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
        }

        [Test]
        public void Complete_3DS_Payment()
        {
            var request = new CompleteThreeDSPaymentRequest
            {
                PaymentId = 1
            };

            var response = _craftgateClient.Payment().Complete3DSPayment(request);
            Assert.NotNull(response);
        }

        [Test]
        public void Init_Checkout_Payment()
        {
            var request = new InitCheckoutPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                CallbackUrl = "https://www.your-website.com/craftgate-checkout-callback",
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

            var response = _craftgateClient.Payment().InitCheckoutPayment(request);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.PageUrl);
            Assert.NotNull(response.TokenExpireDate);
        }

        [Test]
        public void Init_Checkout_Payment_For_Deposit()
        {
            var request = new InitCheckoutPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.PRODUCT,
                CallbackUrl = "https://www.your-website.com/craftgate-checkout-callback",
                DepositPayment = true,
            };

            var response = _craftgateClient.Payment().InitCheckoutPayment(request);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.PageUrl);
            Assert.NotNull(response.TokenExpireDate);
        }

        [Test]
        public void Create_Deposit_Payment()
        {
            var request = new CreateDepositPaymentRequest
            {
                Price = new decimal(100.0),
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                }
            };

            var response = _craftgateClient.Payment().CreateDepositPayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.BuyerMemberId, response.BuyerMemberId);
            Assert.AreEqual("SUCCESS", response.PaymentStatus);
            Assert.AreEqual("DEPOSIT_PAYMENT", response.PaymentType);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
            Assert.NotNull(response.WalletTransaction);
        }

        [Test]
        public void Init_3DS_Deposit_Payment()
        {
            var request = new CreateDepositPaymentRequest
            {
                Price = new decimal(100.0),
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                }
            };

            var response = _craftgateClient.Payment().Init3DSDepositPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
        }

        [Test]
        public void Complete_3DS_Deposit_Payment()
        {
            var request = new CompleteThreeDSPaymentRequest
            {
                PaymentId = 1
            };

            var response = _craftgateClient.Payment().Complete3DSDepositPayment(request);
            Assert.NotNull(response);
            Assert.AreEqual(new decimal(100), response.Price);
            Assert.AreEqual("SUCCESS", response.PaymentStatus);
            Assert.AreEqual("DEPOSIT_PAYMENT", response.PaymentType);
        }

        [Test]
        public void Create_Fund_Transfer_Deposit_Payment()
        {
            var request = new CreateFundTransferDepositPaymentRequest
            {
                Price = new decimal(100.0),
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5"
            };

            var response = _craftgateClient.Payment().CreateFundTransferDepositPayment(request);
            Assert.AreEqual(request.BuyerMemberId, response.BuyerMemberId);
            Assert.NotNull(response.WalletTransaction);
            Assert.AreEqual(request.Price, response.WalletTransaction.Amount);
            Assert.AreEqual(WalletTransactionType.DEPOSIT_FROM_FUND_TRANSFER.ToString(),
                response.WalletTransaction.WalletTransactionType);
        }

        [Test]
        public void Init_Apm_Deposit_Payment()
        {
            var request = new InitApmDepositPaymentRequest()
            {
                ApmType = ApmType.PAPARA,
                Price = new decimal(1.0),
                Currency = Currency.TRY,
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                ClientIp = "127.0.0.1"
            };

            var response = _craftgateClient.Payment().InitApmDepositPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_GarantiPay_Payment()
        {
            var request = new InitGarantiPayPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                CallbackUrl = "https://www.your-website.com/craftgate-garantipay-callback",
                EnabledInstallments = new List<int> {2, 3},
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
                },
                Installments = new List<GarantiPayInstallment>
                {
                    new GarantiPayInstallment
                    {
                        Number = 2,
                        TotalPrice = 120
                    },
                    new GarantiPayInstallment
                    {
                        Number = 3,
                        TotalPrice = 125
                    }
                }
            };

            var response = _craftgateClient.Payment().InitGarantiPayPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
            Assert.NotNull(response.PaymentId);
        }

        [Test]
        public void Init_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.PAPARA,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_Sodexo_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.SODEXO,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                ApmUserIdentity = "5555555555",
                AdditionalParams = new Dictionary<string, object>
                {
                    { "sodexoCode", "843195" }
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
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.SUCCESS);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.NONE);
        }

        [Test]
        public void Init_Edenred_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.EDENRED,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                ApmUserIdentity = "6036819041742253",
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
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.OTP_REQUIRED);
        }
        
        [Test]
        public void Init_Setcard_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.SETCARD,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
                },
                AdditionalParams = new Dictionary<string, object>
                {
                    { "cardNumber", "7599640961180814" }
                },
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.OTP_REQUIRED);
        }

        [Test]
        public void Init_IWallet_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.IWALLET,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                ApmUserIdentity = "1111222233334444",
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
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.OTP_REQUIRED);
        }
        
        [Test]
        public void Init_IWallet_Apm_Payment_with_card_password()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.IWALLET,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                AdditionalParams = new Dictionary<string, object>
                {
                    { "cardNumber", "1111222233334444" }
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
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.SUCCESS);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.NONE);
        }

        [Test]
        public void Init_Kaspi_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.KASPI,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.KZT,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_Tompay_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("channel", "channel");
            additionalParams.Add("phone", "phone");

            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.TOMPAY,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.WAIT_FOR_WEBHOOK);
        }

        [Test]
        public void Init_Chippin_Apm_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.CHIPPIN,
                ApmUserIdentity = "1000000",  // Chippin Kullanıcı No
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
                },
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.WAIT_FOR_WEBHOOK);
        }
        
        [Test]
        public void Init_Bizum_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("buyerPhoneNumber", "34700000000");
            
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.BIZUM,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.EUR,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
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
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.WAIT_FOR_WEBHOOK);
        }
        
        [Test]
        public void Init_Mbway_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("buyerPhoneNumber", "34700000000");
            
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.PAYLANDS_MB_WAY,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.EUR,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
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
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.WAIT_FOR_WEBHOOK);
        }
        
        [Test]
        public void Init_Paycell_DCB_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("paycellGsmNumber", "5305289290");
            
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.PAYCELL_DCB,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
                CallbackUrl = "callbackUrl",
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
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.OTP_REQUIRED);
        }

        [Test]
        public void Init_Paymob_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("integrationId", "11223344");

            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.PAYMOB,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.EGP,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ExternalId = "externalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
                },
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Complete_Edenred_Apm_Payment()
        {
            var request = new CompleteApmPaymentRequest
            {
                PaymentId = 1,
                AdditionalParams = new Dictionary<string, object>
                {
                    { "otpCode", "784294" }
                },
            };

            var response = _craftgateClient.Payment().CompleteApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(PaymentStatus.SUCCESS, response.PaymentStatus);
            Assert.NotNull(response.ConversationId);
        }
        
        [Test]
        public void Complete_Setcard_Apm_Payment()
        {
            var request = new CompleteApmPaymentRequest
            {
                PaymentId = 1,
                AdditionalParams = new Dictionary<string, object>
                {
                    { "otpCode", "784294" }
                },
            };

            var response = _craftgateClient.Payment().CompleteApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(PaymentStatus.SUCCESS, response.PaymentStatus);
            Assert.NotNull(response.ConversationId);
        }

        [Test]
        public void Complete_IWallet_Apm_Payment()
        {
            var request = new CompleteApmPaymentRequest
            {
                PaymentId = 1,
                AdditionalParams = new Dictionary<string, object>
                {
                    { "passCode", "1122" }
                },
            };

            var response = _craftgateClient.Payment().CompleteApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(PaymentStatus.SUCCESS, response.PaymentStatus);
        }

        [Test]
        public void Init_Metropol_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("cardNumber", "6375780115068760");

            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.METROPOL,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
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
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.OTP_REQUIRED);
        }

        public void Complete_Metropol_Apm_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("otpCode", "00000");
            additionalParams.Add("productId", "1");
            additionalParams.Add("walletId", "1");

            var request = new CompleteApmPaymentRequest
            {
                PaymentId = 1,
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().CompleteApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.SUCCESS);
        }

        [Test]
        public void Init_PayPal_APM_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.PAYPAL,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.USD,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ExternalId = "optional-ExternalId",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
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
            Assert.Null(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_Klarna_APM_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("country", "de");
            additionalParams.Add("locale", "en-DE");

            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.KLARNA,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.USD,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.4)
                    },

                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.6)
                    }
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_Afterpay_APM_Payment()
        {
            var request = new InitApmPaymentRequest
            {
                ApmType = ApmType.AFTERPAY,
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.USD,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.4)
                    },

                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.6)
                    }
                }
            };

            var response = _craftgateClient.Payment().InitApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_Ykb_World_Pay_Pos_Apm_Payment()
        {
            var request = new InitPosApmPaymentRequest
            {
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                PaymentProvider = PosApmPaymentProvider.YKB_WORLD_PAY,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.4)
                    },

                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.6)
                    }
                },
                AdditionalParams = new Dictionary<string, object>
                {
                    { "sourceCode", "WEB2QR" }
                },
            };

            var response = _craftgateClient.Payment().InitPosApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.HtmlContent);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, AdditionalAction.SHOW_HTML_CONTENT);
        }

        [Test]
        public void Init_Garanti_Pay_Pos_Apm_Payment()
        {
            var request = new InitPosApmPaymentRequest
            {
                Price = new decimal(1.0),
                PaidPrice = new decimal(1.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                PaymentProvider = PosApmPaymentProvider.GARANTI_PAY,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.4)
                    },

                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(0.6)
                    }
                },
                AdditionalParams = new Dictionary<string, object>
                {
                    { "integrationType", "WEB2APP" }
                },
            };

            var response = _craftgateClient.Payment().InitPosApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.AdditionalData["redirectUrl"]);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, AdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Create_Cash_on_Delivery_Payment()
        {
            var request = new CreateApmPaymentRequest
            {
                ApmType = ApmType.CASH_ON_DELIVERY,
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "241cf73c-7ef1-4e29-a6cc-f37905f2fc3d",
                ExternalId = "optional-ExternalId",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(40)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(60)
                    }
                }
            };

            var response = _craftgateClient.Payment().CreateApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(PaymentStatus.SUCCESS.ToString(), response.PaymentStatus);
            Assert.AreEqual(PaymentType.APM.ToString(), response.PaymentType);
            Assert.AreEqual("241cf73c-7ef1-4e29-a6cc-f37905f2fc3d", response.ConversationId);
            Assert.AreEqual(2, response.PaymentTransactions.Count);
        }

        [Test]
        public void Create_Fund_Transfer_Payment()
        {
            var request = new CreateApmPaymentRequest
            {
                ApmType = ApmType.FUND_TRANSFER,
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "2bc39889-b34f-40b0-abb0-4ab344360705",
                ExternalId = "optional-ExternalId",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(40)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(60)
                    }
                }
            };

            var response = _craftgateClient.Payment().CreateApmPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(PaymentStatus.SUCCESS.ToString(), response.PaymentStatus);
            Assert.AreEqual(PaymentType.APM.ToString(), response.PaymentType);
            Assert.AreEqual("2bc39889-b34f-40b0-abb0-4ab344360705", response.ConversationId);
            Assert.AreEqual(2, response.PaymentTransactions.Count);
        }

        [Test]
        public void Retrieve_Loyalties()
        {
            var request = new RetrieveLoyaltiesRequest
            {
                CardNumber = "4043080000000003",
                ExpireYear = "2044",
                ExpireMonth = "07",
                Cvc = "000"
            };

            var response = _craftgateClient.Payment().RetrieveLoyalties(request);
            Assert.NotNull(response);
            Assert.AreEqual("Bonus", response.CardBrand);
            Assert.IsNotEmpty(response.Loyalties);
            Assert.AreEqual(LoyaltyType.REWARD_MONEY, response.Loyalties[0].Type);
            Assert.IsNotNull(response.Loyalties[0].Reward);
            Assert.AreEqual(new decimal(12.35), response.Loyalties[0].Reward.CardRewardMoney);
            Assert.AreEqual(new decimal(5.20), response.Loyalties[0].Reward.FirmRewardMoney);
        }

        [Test]
        public void Retrieve_Payment()
        {
            long paymentId = 1;

            var response = _craftgateClient.Payment().RetrievePayment(paymentId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentId, response.Id);
        }

        [Test]
        public void Retrieve_Checkout_Payment()
        {
            var token = "456d1297-908e-4bd6-a13b-4be31a6e47d5";

            var response = _craftgateClient.Payment().RetrieveCheckoutPayment(token);
            Assert.NotNull(response.Id);
            Assert.NotNull(response.Price);
            Assert.NotNull(response.PaidPrice);
            Assert.NotNull(response.WalletPrice);
            Assert.NotNull(response.Currency);
            Assert.NotNull(response.Installment);
            Assert.NotNull(response.PaymentGroup);
            Assert.NotNull(response.PaymentPhase);
            Assert.NotNull(response.IsThreeDS);
            Assert.NotNull(response.MerchantCommissionRate);
            Assert.NotNull(response.MerchantCommissionRateAmount);
            Assert.NotNull(response.PaidWithStoredCard);
            Assert.NotNull(response.BinNumber);
            Assert.NotNull(response.LastFourDigits);
            Assert.NotNull(response.CardType);
            Assert.NotNull(response.CardAssociation);
            Assert.NotNull(response.CardBrand);
            Assert.NotNull(response.PaymentTransactions.Count);
            Assert.NotNull(response.CardUserKey);
            Assert.NotNull(response.CardToken);
        }

        [Test]
        public void Delete_Payout_Account()
        {
            var token = "456d1297-908e-4bd6-a13b-4be31a6e47d5";

            _craftgateClient.Payment().ExpireCheckoutPayment(token);
        }

        [Test]
        public void Refund_Payment()
        {
            var request = new RefundPaymentRequest
            {
                PaymentId = 1,
                RefundDestinationType = RefundDestinationType.PROVIDER
            };

            var response = _craftgateClient.Payment().RefundPayment(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.PaymentId, response.PaymentId);
            Assert.AreEqual("SUCCESS", response.Status);
        }
        
        [Test]
        public void Refund_Waiting_Payment()
        {
            var request = new RefundWaitingPaymentRequest
            {
                PaymentId = 1,
            };

            var response = _craftgateClient.Payment().RefundWaitingPayment(request);
            Assert.NotNull(response);
            Assert.AreEqual("SUCCESS", response.Status);
        }
        
        [Test]
        public void Refund_Payment_Mark_As_Refunded()
        {
            var request = new RefundPaymentRequest
            {
                PaymentId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                RefundDestinationType = RefundDestinationType.PROVIDER
            };

            var response = _craftgateClient.Payment().refundPaymentMarkAsRefunded(request);
            Assert.NotNull(response);
        }
        
        [Test]
        public void Refund_Payment_Transaction_Mark_As_Refunded()
        {
            var request = new RefundPaymentTransactionMarkAsRefundedRequest
            {
                PaymentTransactionId = 1,
                RefundPrice = 20
            };

            var response = _craftgateClient.Payment().refundPaymentTransactionMarkAsRefunded(request);
            Assert.NotNull(response);
        }

        [Test]
        public void Retrieve_Payment_Refund()
        {
            long paymentRefundId = 1;

            var response = _craftgateClient.Payment().RetrievePaymentRefund(paymentRefundId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentRefundId, response.Id);
        }

        [Test]
        public void Refund_Payment_Transaction()
        {
            var request = new RefundPaymentTransactionRequest
            {
                PaymentTransactionId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                RefundPrice = 20,
                RefundDestinationType = RefundDestinationType.PROVIDER
            };

            var response = _craftgateClient.Payment().RefundPaymentTransaction(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.PaymentTransactionId, response.PaymentTransactionId);
            Assert.AreEqual("SUCCESS", response.Status);
        }

        [Test]
        public void Retrieve_Payment_Transaction_Refund()
        {
            long paymentTransactionRefundId = 1;

            var response = _craftgateClient.Payment().RetrievePaymentTransactionRefund(paymentTransactionRefundId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentTransactionRefundId, response.Id);
            Assert.AreEqual("SUCCESS", response.Status);
        }

        [Test]
        public void Store_Card()
        {
            var request = new StoreCardRequest
            {
                CardAlias = "My YKB Card",
                CardUserKey = "c115ecdf-0afc-4d83-8a1b-719c2af19cbd",
                CardHolderName = "Haluk Demir",
                CardNumber = "5258640000000001",
                ExpireYear = "2044",
                ExpireMonth = "07"
            };

            var response = _craftgateClient.Payment().StoreCard(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.CardAlias, response.CardAlias);
            Assert.AreEqual(request.CardUserKey, response.CardUserKey);
            Assert.AreEqual(request.CardHolderName, response.CardHolderName);
            Assert.NotNull(response.CardToken);
            Assert.NotNull(response.CreatedAt);
        }

        [Test]
        public void Store_Card_With_Secure_Fields()
        {
            var request = new StoreCardRequest
            {
                SecureFieldsToken = "xxXXxx"
            };
            
            var response = _craftgateClient.Payment().StoreCard(request);
            Assert.NotNull(response);
            Assert.NotNull(response);
            Assert.NotNull(response.CardToken);
            Assert.NotNull(response.CreatedAt);
        }

        [Test]
        public void Update_Stored_Card()
        {
            var request = new UpdateCardRequest
            {
                CardToken = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                CardUserKey = "11a078c4-3c32-4796-90b1-51ee5517a212",
                ExpireYear = "2044",
                ExpireMonth = "07"
            };

            var response = _craftgateClient.Payment().UpdateCard(request);
            Assert.NotNull(response);
            Assert.NotNull(response.CardToken);
            Assert.AreEqual(request.CardUserKey, response.CardUserKey);
            Assert.AreEqual(request.CardToken, response.CardToken);
        }

        [Test]
        public void Clone_Stored_Card()
        {
            var request = new CloneCardRequest
            {
                SourceCardUserKey = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                SourceCardToken = "11a078c4-3c32-4796-90b1-51ee5517a212",
                TargetMerchantId = 1
            };

            var response = _craftgateClient.Payment().CloneCard(request);
            Assert.NotNull(response);
            Assert.NotNull(response.CardToken);
            Assert.NotNull(response.CardUserKey);
        }

        [Test]
        public void Search_Stored_Cards()
        {
            var request = new SearchStoredCardsRequest
            {
                CardAlias = "My YKB Card",
                CardBankName = "YAPI VE KREDİ BANKASI A.Ş.",
                CardBrand = "World",
                CardAssociation = CardAssociation.MASTER_CARD,
                CardToken = "d9b19d1a-243c-43dc-a498-add08162df72",
                CardUserKey = "c115ecdf-0afc-4d83-8a1b-719c2af19cbd",
                CardType = CardType.CREDIT_CARD
            };

            var response = _craftgateClient.Payment().SearchStoredCards(request);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Delete_Stored_Card()
        {
            var request = new DeleteStoredCardRequest
            {
                CardToken = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                CardUserKey = "11a078c4-3c32-4796-90b1-51ee5517a212"
            };
            Assert.DoesNotThrow(() => _craftgateClient.Payment().DeleteStoredCard(request));
        }

        [Test]
        public void Approve_Payment_Transactions()
        {
            var request = new ApprovePaymentTransactionsRequest
            {
                PaymentTransactionIds = new HashSet<long> { 1, 2 },
                IsTransactional = true
            };

            var response = _craftgateClient.Payment().ApprovePaymentTransactions(request);
            Assert.NotNull(response);
            Assert.AreEqual(2, response.Size);
        }

        [Test]
        public void Disapprove_Payment_Transactions()
        {
            var request = new DisapprovePaymentTransactionsRequest
            {
                PaymentTransactionIds = new HashSet<long> { 1, 2 },
                IsTransactional = true
            };

            var response = _craftgateClient.Payment().DisapprovePaymentTransactions(request);
            Assert.NotNull(response);
            Assert.AreEqual(2, response.Size);
        }

        [Test]
        public void Create_Pre_Auth_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                PaymentPhase = PaymentPhase.PRE_AUTH,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
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

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("PRE_AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual("CREDIT_CARD", response.CardType);
            Assert.AreEqual("MASTER_CARD", response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Post_Auth_Payment()
        {
            long paymentId = 1;
            var request = new PostAuthPaymentRequest
            {
                PaidPrice = new decimal(100.0)
            };

            var response = _craftgateClient.Payment().PostAuthPayment(paymentId, request);
            Assert.AreEqual(paymentId, response.Id);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual("POST_AUTH", response.PaymentPhase);
        }

        [Test]
        public void Create_MultiCurrency_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.USD,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5400010000000004",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
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

            var response = _craftgateClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual("USD", response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual("LISTING_OR_SUBSCRIPTION", response.PaymentGroup);
            Assert.AreEqual("AUTH", response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("540001", response.BinNumber);
            Assert.AreEqual("0004", response.LastFourDigits);
            Assert.AreEqual(null, response.CardType);
            Assert.AreEqual(null, response.CardAssociation);
            Assert.AreEqual(null, response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Update_Payment_Transaction()
        {
            var request = new UpdatePaymentTransactionRequest
            {
                SubMerchantMemberId = 1,
                PaymentTransactionId = 10,
                SubMerchantMemberPrice = new decimal(10.0)
            };

            var response = _craftgateClient.Payment().UpdatePaymentTransaction(request);
            Assert.AreEqual(request.SubMerchantMemberId, response.SubMerchantMemberId);
            Assert.AreEqual(request.SubMerchantMemberPrice, response.SubMerchantMemberPrice);
        }

        [Test]
        public void Verify_3DS_Callback()
        {
            string merchantThreeDsCallbackKey = "merchantThreeDsCallbackKeySndbox";
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "hash", "1d3fa1e51fe7c350185c5a7f8c3ff513a991367b08c16a56f4ab9abeb738a1e1" },
                { "paymentId", "5" },
                { "conversationData", "conversation-data" },
                { "conversationId", "conversation-id" },
                { "status", "SUCCESS" },
                { "completeStatus", "WAITING" }
            };

            var isVerified = _craftgateClient.Payment()
                .Is3DSecureCallbackVerified(merchantThreeDsCallbackKey, parameters);
            Assert.True(isVerified);
        }

        [Test]
        public void Verify_3DS_Callback_Even_Params_Has_Nullable_Value()
        {
            string merchantThreeDsCallbackKey = "merchantThreeDsCallbackKeySndbox";
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "hash", "a097f0231031a88f2d687b510afca2505ccd2977d6421be4c3784666703f6f25" },
                { "paymentId", "5" },
                { "conversationId", "conversation-id" },
                { "status", "SUCCESS" },
                { "completeStatus", "WAITING" }
            };

            var isVerified = _craftgateClient.Payment()
                .Is3DSecureCallbackVerified(merchantThreeDsCallbackKey, parameters);
            Assert.True(isVerified);
        }

        [Test]
        public void Not_Verify_3DS_Callback()
        {
            string merchantThreeDsCallbackKey = "merchantThreeDsCallbackKeySndbox";
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "hash", "39427942bcaasjaduqabzhdancaASasdhbcxjancakjscace82" },
                { "paymentId", "5" },
                { "conversationData", "conversation-data" },
                { "conversationId", "conversation-id" },
                { "status", "SUCCESS" },
                { "completeStatus", "WAITING" }
            };

            var isVerified = _craftgateClient.Payment()
                .Is3DSecureCallbackVerified(merchantThreeDsCallbackKey, parameters);
            Assert.False(isVerified);
        }

        [Test]
        public void Retrieve_Bnpl_Offers()
        {
            var request = new BnplPaymentOfferRequest()
            {
                Price = new decimal(10000.0),
                Currency = Currency.TRY,
                ApmType = ApmType.MASLAK,
                ApmOrderId = Guid.NewGuid().ToString(),
                Items = new List<BnplPaymentCartItem>
                {
                    new BnplPaymentCartItem()
                    {
                        Id = "1234",
                        Name = "Item 1",
                        BrandName = "Item 1",
                        UnitPrice = new decimal(7000.0),
                        Quantity = 1,
                        Type = BnplCartItemType.TV
                    },
                    new BnplPaymentCartItem()
                    {
                        Id = "1234",
                        Name = "Item 2",
                        BrandName = "Item 2",
                        UnitPrice = new decimal(3000.0),
                        Quantity = 1,
                        Type = BnplCartItemType.TV
                    }
                }
            };

            var response = _craftgateClient.Payment().RetrieveBnplOffers(request);
            Assert.NotNull(response.OfferId);
            Assert.IsNotEmpty(request.Items);
        }

        [Test]
        public void Init_Bnpl_Payment()
        {
            var request = new InitBnplPaymentRequest
            {
                ApmType = ApmType.MASLAK,
                Price = new decimal(10000.0),
                PaidPrice = new decimal(10000.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                ApmOrderId = Guid.NewGuid().ToString(),
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                BankCode = "103", // fibabank
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(10000)
                    }
                },
                CartItems = new List<BnplPaymentCartItem>
                {
                    new BnplPaymentCartItem()
                    {
                        Id = "1234",
                        Name = "Item 1",
                        BrandName = "Item 1",
                        UnitPrice = new decimal(10000.0),
                        Quantity = 1,
                        Type = BnplCartItemType.TV
                    }
                }
            };

            var response = _craftgateClient.Payment().InitBnplPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Init_TomFinance_Bnpl_Payment()
        {
            var additionalParams = new Dictionary<string, object>();
            additionalParams.Add("buyerName", "John Doe");
            additionalParams.Add("buyerPhoneNumber", "5554443322");

            var request = new InitBnplPaymentRequest
            {
                ApmType = ApmType.TOM_FINANCE,
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                Currency = Currency.TRY,
                PaymentGroup = PaymentGroup.LISTING_OR_SUBSCRIPTION,
                ConversationId = "conversationId",
                ApmOrderId = Guid.NewGuid().ToString(),
                CallbackUrl = "https://www.your-website.com/craftgate-apm-callback",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(100)
                    }
                },
                CartItems = new List<BnplPaymentCartItem>
                {
                    new BnplPaymentCartItem()
                    {
                        Id = "26020874",
                        Name = "Item 1",
                        BrandName = "26010303",
                        UnitPrice = new decimal(100.0),
                        Quantity = 1,
                        Type = BnplCartItemType.OTHER
                    }
                },
                AdditionalParams = additionalParams
            };

            var response = _craftgateClient.Payment().InitBnplPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PaymentId);
            Assert.NotNull(response.RedirectUrl);
            Assert.AreEqual(response.PaymentStatus, PaymentStatus.WAITING);
            Assert.AreEqual(response.AdditionalAction, ApmAdditionalAction.REDIRECT_TO_URL);
        }

        [Test]
        public void Approve_Bnpl_Payment()
        {
            var PaymentId = 1;

            _craftgateClient.Payment().ApproveBnplPayment(PaymentId);
        }
        
        [Test]
        public void Verify_Bnpl_Payment()
        {
            var PaymentId = 1;

            _craftgateClient.Payment().VerifyBnplPayment(PaymentId);
        }

        [Test]
        public void Retrieve_Multi_Payment()
        {
            var token = "6d7e66b5-9b1c-4c1d-879a-2557b651096e";

            var response = _craftgateClient.Payment().RetrieveMultiPayment(token);

            Assert.NotNull(response.Id);
            Assert.NotNull(response.MultiPaymentStatus);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.PaidPrice);
            Assert.NotNull(response.RemainingAmount);
            Assert.NotNull(response.PaymentIds);
        }

        [Test]
        public void Retrieve_Provider_Card()
        {
            var request = new RetrieveProviderCardRequest
            {

                ProviderCardToken = "45f12c74-3000-465c-96dc-876850e7dd7a",
                ExternalId = "1001",
                ProviderCardUserId = "0309ac2d-c5a5-4b4f-a91f-5c444ba07b24",
                CardProvider = CardProvider.MEX.ToString()
            };

            var response = _craftgateClient.Payment().RetrieveProviderCards(request);

            Assert.NotNull(response);
        }

        [Test]
        public void Init_Checkout_Card_Verify_With_Non_3DS_Auth_Type()
        {
            var request = new InitCheckoutCardVerifyRequest
            {
                CallbackUrl = "https://www.your-website.com/craftgate-checkout-card-verify-callback",
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                PaymentAuthenticationType = CardVerificationAuthType.NON_THREE_DS,
                VerificationPrice = new decimal(10.0),
                Currency = Currency.TRY
            };

            var response = _craftgateClient.Payment().InitCheckoutCardVerify(request);
            Assert.NotNull(response);
            Assert.NotNull(response.PageUrl);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.TokenExpireDate);
        }

        [Test]
        public void Verify_Card_With_3DS()
        {
            var request = new VerifyCardRequest
            {
                Card = new VerifyCard
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000",
                    CardAlias = "My YKB Card"
                },
                PaymentAuthenticationType = CardVerificationAuthType.THREE_DS,
                CallbackUrl = "https://www.your-website.com/craftgate-3DSecure-card-verify-callback",
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                VerificationPrice = new decimal(10.0),
                Currency = Currency.TRY,
                ClientIp = "127.0.0.1"
            };

            var response = _craftgateClient.Payment().VerifyCard(request);
            Assert.NotNull(response);
            Assert.AreEqual(CardVerifyStatus.THREE_DS_PENDING, response.CardVerifyStatus);
            Assert.NotNull(response.HtmlContent);
        }

        [Test]
        public void Retrieve_Checkout_Card_Verify()
        {
            var token = "456d1297-908e-4bd6-a13b-4be31a6e47d5";

            var response = _craftgateClient.Payment().RetrieveCheckoutCardVerify(token);
            Assert.NotNull(response);
            Assert.NotNull(response.Token);
        }
    }
}
