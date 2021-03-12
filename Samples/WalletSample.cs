using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class WalletSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Search_Wallets()
        {
            var request = new SearchWalletsRequest()
            {
                MemberId = 1L
            };

            var response = _craftgateClient.Wallet().SearchWallets(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Wallet_Transactions()
        {
            long walletId = 1;
            var request = new SearchWalletTransactionsRequest
            {
            };

            var response = _craftgateClient.Wallet().SearchWalletTransactions(walletId, request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Send_Remittance()
        {
            long memberId = 1;
            decimal price = new decimal(50.0);
            var request = new CreateRemittanceRequest
            {
                MemberId = memberId,
                Price = price,
                Description = "Remittance send to memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.Remittance
            };

            var response = _craftgateClient.Wallet().SendRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual(RemittanceType.Send, response.RemittanceType);
            Assert.AreEqual(RemittanceReasonType.Remittance, response.RemittanceReasonType);
        }

        [Test]
        public void Receive_Remittance()
        {
            long memberId = 1;
            decimal price = new decimal(50.0);
            var request = new CreateRemittanceRequest
            {
                MemberId = memberId,
                Price = price,
                Description = "Remittance received from memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.Remittance
            };

            var response = _craftgateClient.Wallet().ReceiveRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual(RemittanceType.Receive, response.RemittanceType);
            Assert.AreEqual(RemittanceReasonType.Remittance, response.RemittanceReasonType);
        }

        [Test]
        public void Retrieve_Merchant_Member_Wallet()
        {
            var response = _craftgateClient.Wallet().RetrieveMerchantMemberWallet();

            Assert.NotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.IsNotNull(response.MemberId);
            Assert.IsNotNull(response.Amount);
            Assert.AreEqual(response.Currency, Currency.Try);
        }

        [Test]
        public void Reset_Merchant_Member_Wallet_Balance()
        {
            var request = new ResetMerchantMemberWalletBalanceRequest
            {
                WalletAmount = new decimal(-100)
            };

            var response = _craftgateClient.Wallet().ResetMerchantMemberWalletBalance(request);

            Assert.NotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.IsNotNull(response.MemberId);
            Assert.AreEqual(response.Amount, decimal.Zero);
            Assert.AreEqual(response.Currency, Currency.Try);
        }

        [Test]
        public void Retrieve_Refundable_Amount_Of_Wallet_Transaction()
        {
            long walletTransactionId = 1;
            var response = _craftgateClient.Wallet().RetrieveRefundableAmountOfWalletTransaction(walletTransactionId);

            Assert.GreaterOrEqual(response.RefundableAmount, decimal.Zero);
        }

        [Test]
        public void Refund_Wallet_Transaction_To_Card()
        {
            long walletTransactionId = 1;
            var request = new RefundWalletTransactionToCardRequest
            {
                RefundPrice = new decimal(10)
            };
            var response = _craftgateClient.Wallet().RefundWalletTransactionToCard(walletTransactionId, request);

            Assert.IsNotNull(response.Id);
            Assert.IsNull(response.PaymentError);
            Assert.AreEqual(response.RefundStatus, RefundStatus.Success);
            Assert.AreEqual(response.TransactionType, WalletTransactionRefundCardTransactionType.Payment);
            Assert.AreEqual(response.WalletTransactionId, walletTransactionId);
            Assert.AreEqual(response.RefundPrice, request.RefundPrice);
        }

        [Test]
        public void Retrieve_Wallet_Transactions_To_Card()
        {
            long walletTransactionId = 1;
            var response = _craftgateClient.Wallet().RetrieveRefundWalletTransactionsToCard(walletTransactionId);

            Assert.IsNotNull(response.Items);
            Assert.GreaterOrEqual(response.Items.Count, 0);
        }

        [Test]
        public void Create_Withdraw()
        {
            var request = new CreateWithdrawRequest
            {
                MemberId = 1,
                Price = new decimal(100),
                Description = "Hakediş Çekme Talebi",
                Currency = Currency.Try
            };

            var response = _craftgateClient.Wallet().CreateWithdraw(request);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual(response.Price, request.Price);
            Assert.AreEqual(response.Status, Status.Active);
            Assert.AreEqual(response.MemberId, request.MemberId);
            Assert.AreEqual(response.Currency, request.Currency);
            Assert.AreEqual(response.Description, request.Description);
            Assert.AreEqual(response.PayoutStatus, PayoutStatus.WaitingForPayout);
        }


        [Test]
        public void Cancel_Withdraw()
        {
            var withdrawId = 1;

            var response = _craftgateClient.Wallet().CancelWithdraw(withdrawId);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual(response.Status, Status.Active);
            Assert.AreEqual(response.PayoutStatus, PayoutStatus.Cancelled);
        }

        [Test]
        public void Retrieve_Withdraw()
        {
            var withdrawId = 1;

            var response = _craftgateClient.Wallet().RetrieveWithdraw(withdrawId);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual(response.Status, Status.Active);
            Assert.AreEqual(response.Currency, Currency.Try);
            Assert.AreEqual(response.PayoutStatus, PayoutStatus.WaitingForPayout);
        }

        [Test]
        public void Search_Withdraws()
        {
            var request = new SearchWithdrawsRequest
            {
                PayoutStatus = PayoutStatus.WaitingForPayout,
                MinWithdrawPrice = new decimal(5),
                MaxWithdrawPrice = new decimal(1000)
            };

            var response = _craftgateClient.Wallet().SearchWithdraws(request);

            Assert.IsNotNull(response.Page);
            Assert.IsNotNull(response.Size);
            Assert.IsNotNull(response.TotalSize);
            Assert.GreaterOrEqual(response.Items.Count, 0);
        }
    }
}