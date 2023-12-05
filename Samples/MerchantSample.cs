using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class MerchantSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Merchant_Pos()
        {
            var request = new CreateMerchantPosRequest()
            {
                Name = "my test pos",
                ClientId = "client id",
                TerminalId = "terminal id",
                ThreedsKey = "3d secure key",
                Status = PosStatus.AUTOPILOT,
                Currency = Currency.TRY,
                OrderNumber = 1,
                EnableInstallment = true,
                EnableForeignCard = true,
                EnablePaymentWithoutCvc = true,
                PosIntegrator = PosIntegrator.AKBANK,
                EnabledPaymentAuthenticationTypes = new List<PaymentAuthenticationType>
                {
                    PaymentAuthenticationType.NON_THREE_DS, PaymentAuthenticationType.THREE_DS
                },
                MerchantPosUsers = new List<CreateMerchantPosUser>
                {
                    new CreateMerchantPosUser()
                    {
                        PosOperationType = PosOperationType.STANDARD,
                        PosUserType = PosUserType.API,
                        PosUsername = "username",
                        PosPassword = "password",
                    }
                }
            };

            var response = _craftgateClient.Merchant().CreateMerchantPos(request);
            Assert.NotNull(response.Id);
            Assert.NotNull(response.Alias);
            Assert.AreEqual(request.PosIntegrator, PosIntegrator.AKBANK);
        }

        [Test]
        public void Retrieve_Merchant_Pos()
        {
            const int id = 1;

            var response = _craftgateClient.Merchant().RetrieveMerchantPos(id);
            Assert.NotNull(response.Id);
            Assert.NotNull(response.Alias);
            Assert.AreEqual(id, response.Id);
        }

        [Test]
        public void Update_Merchant_Pos()
        {
            const int id = 1;
            var request = new UpdateMerchantPosRequest()
            {
                Name = "my test pos",
                Hostname = "https://www.sanalakpos.com",
                Path = "/fim/api",
                ThreedsPath = "https://www.sanalakpos.com/fim/est3dgate",
                ClientId = "client id",
                TerminalId = "terminal id",
                ThreedsKey = "3d secure key",
                Mode = "P",
                OrderNumber = 1,
                EnableInstallment = true,
                EnableForeignCard = true,
                EnablePaymentWithoutCvc = true,
                SupportedCardAssociations = new List<CardAssociation>
                {
                    CardAssociation.VISA, CardAssociation.MASTER_CARD
                },
                EnabledPaymentAuthenticationTypes = new List<PaymentAuthenticationType>
                {
                    PaymentAuthenticationType.NON_THREE_DS, PaymentAuthenticationType.THREE_DS
                },
                MerchantPosUsers = new List<UpdateMerchantPosUser>
                {
                    new UpdateMerchantPosUser()
                    {
                        Id = 1,
                        PosOperationType = PosOperationType.STANDARD,
                        PosUserType = PosUserType.API,
                        PosUsername = "username",
                        PosPassword = "password",
                    }
                }
            };

            var response = _craftgateClient.Merchant().UpdateMerchantPos(id, request);
            Assert.NotNull(response.Id);
            Assert.NotNull(response.Alias);
            Assert.AreEqual(request.Name, "my test pos");
        }


        [Test]
        public void Update_Merchant_Pos_Status()
        {
            const int id = 9;
            const PosStatus posStatus = PosStatus.PASSIVE;

            _craftgateClient.Merchant().UpdateMerchantPosStatus(id, posStatus);
        }

        [Test]
        public void Delete_Merchant_Pos()
        {
            const int id = 9;

            _craftgateClient.Merchant().DeleteMerchantPos(id);
        }

        [Test]
        public void Search_Merchant_Pos()
        {
            var request = new SearchMerchantPosRequest()
            {
                Page = 0,
                Size = 10,
                Currency = Currency.TRY
            };

            var response = _craftgateClient.Merchant().SearchMerchantPos(request);
            Assert.NotNull(response);
            Assert.IsNotEmpty(response.Items);
        }

        [Test]
        public void Retrieve_Merchant_Pos_Commissions()
        {
            const int id = 1;

            var response = _craftgateClient.Merchant().RetrieveMerchantPosCommissions(id);
            Assert.NotNull(response);
            Assert.IsNotEmpty(response.Items);
        }

        [Test]
        public void Update_Merchant_Pos_Commissions()
        {
            const int id = 1;
            var request = new UpdateMerchantPosCommissionsRequest()
            {
                Commissions = new List<UpdateMerchantPosCommission>()
                {
                    new UpdateMerchantPosCommission()
                    {
                        Installment = 1,
                        BlockageDay = 7,
                        Status = Status.ACTIVE,
                        CardBrandName = CardBrand.AXESS,
                        InstallmentLabel = "Single installment",
                        BankOnUsDebitCardCommissionRate = new decimal(1.0),
                        BankOnUsCreditCardCommissionRate = new decimal(1.1),
                        BankNotOnUsDebitCardCommissionRate = new decimal(1.2),
                        BankNotOnUsCreditCardCommissionRate = new decimal(1.3),
                        BankForeignCardCommissionRate = new decimal(1.5)
                    },
                    new UpdateMerchantPosCommission()
                    {
                        Installment = 2,
                        BlockageDay = 7,
                        Status = Status.ACTIVE,
                        CardBrandName = CardBrand.AXESS,
                        InstallmentLabel = "installment 2",
                        BankOnUsCreditCardCommissionRate = new decimal(2.1),
                        MerchantCommissionRate = new decimal(2.3),
                    }
                }
            };

            var response = _craftgateClient.Merchant().UpdateMerchantPosCommissions(id, request);
            Assert.NotNull(response);
            Assert.IsNotEmpty(response.Items);
        }
    }
}