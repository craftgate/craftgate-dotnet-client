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
            _craftgateClient.Settlement().DeletePayoutAccount(13);
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
    }
}