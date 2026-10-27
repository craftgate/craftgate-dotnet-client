using System;
using System.Collections.Generic;
using System.Linq;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Response;
using NUnit.Framework;

namespace Samples
{
    public class SettlementSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Instant_Wallet_Settlement()
        {
            var request = new CreateInstantWalletSettlementRequest();

            SettlementResponse response = _craftgateClient.Settlement().CreateInstantWalletSettlement(request);
            Assert.NotNull(response.SettlementResultStatus);
        }
        
        
        [Test]
        public void Create_Merchant_Payout_Account()
        {
            var request = new CreatePayoutAccountRequest 
            { 
                AccountOwner = AccountOwner.MERCHANT,
                Currency = Currency.USD,
                Type = PayoutAccountType.WISE,
                ExternalAccountId = "wiseRecipientId"
            };

            PayoutAccountResponse response = _craftgateClient.Settlement().CreatePayoutAccount(request);
            Assert.NotNull(response.Id);
        }
        
        [Test]
        public void Create_Sub_Merchant_Payout_Account()
        {
            var request = new CreatePayoutAccountRequest 
            { 
                AccountOwner = AccountOwner.SUB_MERCHANT_MEMBER,
                SubMerchantMemberId = 1L,
                Currency = Currency.USD,
                Type = PayoutAccountType.WISE,
                ExternalAccountId = "wiseRecipientId"
            };

            PayoutAccountResponse response = _craftgateClient.Settlement().CreatePayoutAccount(request);
            Assert.NotNull(response.Id);
        }
        
        [Test]
        public void Update_Payout_Account()
        {
            var request = new UpdatePayoutAccountRequest() 
            { 
                Type = PayoutAccountType.WISE,
                ExternalAccountId = "wiseRecipientId"
            };

            _craftgateClient.Settlement().UpdatePayoutAccount(15, request);
        }
                
        [Test]
        public void Delete_Payout_Account()
        {
            _craftgateClient.Settlement().DeletePayoutAccount(new DeletePayoutAccountRequest {Id = 13});
        }
        
        
        [Test]
        public void Search_Payout_Account()
        {
            var request = new SearchPayoutAccountRequest() 
            { 
                AccountOwner = AccountOwner.MERCHANT,
                Currency = Currency.USD
            };

            PayoutAccountListResponse response = _craftgateClient.Settlement().SearchPayoutAccounts(request);
            Assert.NotNull(response.Items);
        }

        [Test]
        public void Approve_Payment_Transactions()
        {
            var request = new ApprovePaymentTransactionsRequest
            {
                PaymentTransactionIds = new HashSet<long> { 1, 2 },
                IsTransactional = true
            };

            var response = _craftgateClient.Settlement().ApprovePaymentTransactions(request);
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

            var response = _craftgateClient.Settlement().DisapprovePaymentTransactions(request);
            Assert.NotNull(response);
            Assert.AreEqual(2, response.Size);
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

            var response = _craftgateClient.Settlement().UpdatePaymentTransaction(request);
            Assert.AreEqual(request.PaymentTransactionId, response.PaymentTransactionId);
            Assert.True(response.PayoutItems.Any(item =>
                item.MerchantType == MerchantType.SUB_MERCHANT_MEMBER.ToString() && item.MerchantId == request.SubMerchantMemberId));
        }

        [Test]
        public void Update_Payment_Transaction_With_Blockage_Resolved_Date()
        {
            var request = new UpdatePaymentTransactionRequest
            {
                PaymentTransactionId = 2159617,
                BlockageResolvedDate = DateTime.Now.AddDays(5)
            };

            var response = _craftgateClient.Settlement().UpdatePaymentTransaction(request);
            Assert.AreEqual(request.BlockageResolvedDate, response.BlockageResolvedDate);
        }
    }
}