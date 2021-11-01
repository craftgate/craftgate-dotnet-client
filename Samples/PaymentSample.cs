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
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

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
                            {"cardUserKey", "test-cardUserKey"},
                            {"cardToken", "tuz8imxv30"}
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
            var request = new InitCheckoutPaymentRequest()
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
        }

        [Test]
        public void Create_Deposit_Payment()
        {
            var request = new CreateDepositPaymentRequest
            {
                Price = new decimal(100.0),
                BuyerMemberId = 1,
                Currency = Currency.TRY,
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
        }

        [Test]
        public void Init_3DS_Deposit_Payment()
        {
            var request = new CreateDepositPaymentRequest
            {
                Price = new decimal(100.0),
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.TRY,
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
            Assert.Equals(new decimal(100), response.Price);
            Assert.Equals("SUCCESS", response.PaymentStatus);
            Assert.Equals("DEPOSIT_PAYMENT", response.PaymentType);
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
        public void Refund_Payment()
        {
            var request = new RefundPaymentRequest
            {
                PaymentId = 1,
                RefundDestinationType = RefundDestinationType.CARD
            };

            var response = _craftgateClient.Payment().RefundPayment(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.PaymentId, response.PaymentId);
            Assert.AreEqual("SUCCESS", response.Status);
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
                RefundDestinationType = RefundDestinationType.CARD
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
            Assert.NotNull(response.CardToken);
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
                PaymentTransactionIds = new HashSet<long> {1, 2},
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
                PaymentTransactionIds = new HashSet<long> {1, 2},
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
            var request = new PostAuthPaymentRequest()
            {
                PaidPrice = new decimal(100.0)
            };

            var response = _craftgateClient.Payment().PostAuthPayment(paymentId, request);
            Assert.AreEqual(paymentId, response.Id);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual("POST_AUTH", response.PaymentPhase);
        }
        
        [Test]
        public void Check_Masterpass_User()
        {
            var request = new CheckMasterpassUserRequest()
            {
                MasterpassGsmNumber = "903000000000"
            };

            var response = _craftgateClient.Payment().CheckMasterpassUser(request);
            Assert.AreEqual(true, response.IsEligibleToUseMasterpass);
            Assert.NotNull(response);
        }
    }
}