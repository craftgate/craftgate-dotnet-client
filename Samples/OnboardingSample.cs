using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class OnboardingSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Sub_Merchant()
        {
            var request = new CreateMemberRequest
            {
                IsBuyer = false,
                IsSubMerchant = true,
                ContactName = "Haluk",
                ContactSurname = "Demir",
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                IdentityNumber = "11111111110",
                LegalCompanyTitle = "Dem Zeytinyağı Üretim Ltd. Şti.",
                Name = "Dem Zeytinyağı Üretim Ltd. Şti.",
                MemberExternalId = Guid.NewGuid().ToString(),
                MemberType = MemberType.LimitedOrJointStockCompany,
                TaxNumber = "1111111114",
                TaxOffice = "Erenköy",
                Iban = "TR930006701000000001111111",
                SettlementEarningsDestination = SettlementEarningsDestination.Iban,
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul"
            };

            var response = _craftgateClient.Onboarding().CreateMember(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.PhoneNumber, response.PhoneNumber);
            Assert.AreEqual(request.Iban, response.Iban);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.LegalCompanyTitle, response.LegalCompanyTitle);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.MemberExternalId, response.MemberExternalId);
            Assert.AreEqual(request.MemberType, response.MemberType);
            Assert.AreEqual(request.TaxNumber, response.TaxNumber);
            Assert.AreEqual(request.TaxOffice, response.TaxOffice);
            Assert.AreEqual(request.Address, response.Address);
        }

        [Test]
        public void Update_Sub_Merchant()
        {
            var memberId = 1L;

            var request = new UpdateMemberRequest
            {
                IsBuyer = false,
                IsSubMerchant = true,
                ContactName = "Haluk",
                ContactSurname = "Demir",
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                IdentityNumber = "11111111110",
                LegalCompanyTitle = "Dem Zeytinyağı Üretim Ltd. Şti.",
                MemberType = MemberType.LimitedOrJointStockCompany,
                Name = "Dem Zeytinyağı Üretim Ltd. Şti.",
                TaxNumber = "1111111114",
                TaxOffice = "Erenköy",
                Iban = "TR930006701000000001111111",
                SettlementEarningsDestination = SettlementEarningsDestination.Iban,
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul"
            };

            var response = _craftgateClient.Onboarding().UpdateMember(memberId, request);
            Assert.AreEqual(memberId, response.Id);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.PhoneNumber, response.PhoneNumber);
            Assert.AreEqual(request.Iban, response.Iban);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.LegalCompanyTitle, response.LegalCompanyTitle);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.TaxNumber, response.TaxNumber);
            Assert.AreEqual(request.TaxOffice, response.TaxOffice);
            Assert.AreEqual(request.Address, response.Address);
        }

        [Test]
        public void Retrieve_Sub_Merchant()
        {
            var memberId = 1L;

            var response = _craftgateClient.Onboarding().RetrieveMember(memberId);
            Assert.AreEqual(memberId, response.Id);
            Assert.AreEqual(false, response.IsBuyer);
            Assert.AreEqual(true, response.IsSubMerchant);
        }

        [Test]
        public void Search_Sub_Merchants()
        {
            var request = new SearchMemberRequest
            {
                Name = "Zeytinyağı Üretim",
                MemberIds = new HashSet<long> {1, 2}
            };

            var response = _craftgateClient.Onboarding().SearchMembers(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Create_Buyer()
        {
            var request = new CreateMemberRequest
            {
                IsBuyer = true,
                IsSubMerchant = false,
                MemberExternalId = Guid.NewGuid().ToString(),
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                Name = "Haluk Demir",
                IdentityNumber = "11111111110",
                MemberType = MemberType.Personal,
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul",
                ContactName = "Haluk",
                ContactSurname = "Demir"
            };

            var response = _craftgateClient.Onboarding().CreateMember(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.IsBuyer, response.IsBuyer);
            Assert.AreEqual(request.IsSubMerchant, response.IsSubMerchant);
            Assert.AreEqual(request.MemberExternalId, response.MemberExternalId);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.PhoneNumber, response.PhoneNumber);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.Address, response.Address);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
        }

        [Test]
        public void Update_Buyer()
        {
            long memberId = 1;
            var request = new UpdateMemberRequest
            {
                IsBuyer = true,
                IsSubMerchant = false,
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                Name = "Haluk Demir",
                IdentityNumber = "11111111110",
                MemberType = MemberType.Personal,
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul",
                ContactName = "Haluk",
                ContactSurname = "Demir"
            };

            var response = _craftgateClient.Onboarding().UpdateMember(memberId, request);
            Assert.AreEqual(memberId, response.Id);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.PhoneNumber, response.PhoneNumber);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
        }

        [Test]
        public void Retrieve_Buyer()
        {
            var memberId = 1L;

            var response = _craftgateClient.Onboarding().RetrieveMember(memberId);
            Assert.AreEqual(memberId, response.Id);
            Assert.AreEqual(true, response.IsBuyer);
            Assert.AreEqual(false, response.IsSubMerchant);
        }

        [Test]
        public void Create_Sub_Merchant_Buyer()
        {
            var request = new CreateMemberRequest
            {
                IsBuyer = true,
                IsSubMerchant = true,
                ContactName = "Haluk",
                ContactSurname = "Demir",
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                IdentityNumber = "11111111110",
                LegalCompanyTitle = "Dem Zeytinyağı Üretim Ltd. Şti.",
                Name = "Dem Zeytinyağı Üretim Ltd. Şti.",
                MemberExternalId = Guid.NewGuid().ToString(),
                MemberType = MemberType.LimitedOrJointStockCompany,
                TaxNumber = "1111111114",
                TaxOffice = "Erenköy",
                Iban = "TR930006701000000001111111",
                SettlementEarningsDestination = SettlementEarningsDestination.Iban,
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul"
            };

            var response = _craftgateClient.Onboarding().CreateMember(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.PhoneNumber, response.PhoneNumber);
            Assert.AreEqual(request.Iban, response.Iban);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.LegalCompanyTitle, response.LegalCompanyTitle);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.MemberExternalId, response.MemberExternalId);
            Assert.AreEqual(request.MemberType, response.MemberType);
            Assert.AreEqual(request.TaxNumber, response.TaxNumber);
            Assert.AreEqual(request.TaxOffice, response.TaxOffice);
            Assert.AreEqual(request.Address, response.Address);
        }

        [Test]
        public void Retrieve_Sub_Merchant_Buyer()
        {
            var memberId = 1L;

            var response = _craftgateClient.Onboarding().RetrieveMember(memberId);
            Assert.AreEqual(memberId, response.Id);
            Assert.AreEqual(true, response.IsBuyer);
            Assert.AreEqual(true, response.IsSubMerchant);
        }
    }
}