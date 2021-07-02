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
        public void Retrieve_Member_Wallet()
        {
            long memberId = 1L;

            var response = _craftgateClient.Wallet().RetrieveMemberWallet(memberId);

            Assert.NotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual(memberId, response.MemberId);
            Assert.IsNotNull(response.Amount);
            Assert.IsNotNull(response.WithdrawalAmount);
            Assert.AreEqual("TRY", response.Currency);
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
                Description = "Remittance send to sub merchant memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.SUBMERCHANT_SEND_RECEIVE
            };

            var response = _craftgateClient.Wallet().SendRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual("SEND", response.RemittanceType);
            Assert.AreEqual("SUBMERCHANT_SEND_RECEIVE", response.RemittanceReasonType);
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
                Description = "Remittance received from sub merchant memberId" + memberId,
                RemittanceReasonType = RemittanceReasonType.SUBMERCHANT_SEND_RECEIVE
            };

            var response = _craftgateClient.Wallet().ReceiveRemittance(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual("RECEIVE", response.RemittanceType);
            Assert.AreEqual("SUBMERCHANT_SEND_RECEIVE", response.RemittanceReasonType);
        }

        [Test]
        public void Retrieve_Remittance()
        {
            long remittanceId = 1;

            var response = _craftgateClient.Wallet().RetrieveRemittance(remittanceId);
            Assert.NotNull(response.Id);
            Assert.NotNull(response.MemberId);
            Assert.NotNull(response.Price);
            Assert.NotNull(response.Description);
            Assert.AreEqual("SEND", response.RemittanceType);
            Assert.AreEqual("SUBMERCHANT_SEND_RECEIVE", response.RemittanceReasonType);
        }

        [Test]
        public void Retrieve_Merchant_Member_Wallet()
        {
            var response = _craftgateClient.Wallet().RetrieveMerchantMemberWallet();

            Assert.NotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.IsNotNull(response.MemberId);
            Assert.IsNotNull(response.Amount);
            Assert.AreEqual("TRY", response.Currency);
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
            Assert.AreEqual(decimal.Zero, response.Amount);
            Assert.AreEqual("TRY", response.Currency);
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
            Assert.AreEqual("SUCCESS", response.RefundStatus);
            Assert.AreEqual("PAYMENT", response.TransactionType);
            Assert.AreEqual(walletTransactionId, response.WalletTransactionId);
            Assert.AreEqual(request.RefundPrice, response.RefundPrice);
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
                Currency = Currency.TRY
            };

            var response = _craftgateClient.Wallet().CreateWithdraw(request);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.Null(response.PayoutId);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual("ACTIVE", response.Status);
            Assert.AreEqual(request.MemberId, response.MemberId);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual(request.Description, response.Description);
            Assert.AreEqual("WAITING_FOR_PAYOUT", response.PayoutStatus);
        }

        [Test]
        public void Cancel_Withdraw()
        {
            var withdrawId = 1;

            var response = _craftgateClient.Wallet().CancelWithdraw(withdrawId);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual("ACTIVE", response.Status);
            Assert.AreEqual("CANCELLED", response.PayoutStatus);
        }

        [Test]
        public void Retrieve_Withdraw()
        {
            var withdrawId = 1;

            var response = _craftgateClient.Wallet().RetrieveWithdraw(withdrawId);

            Assert.IsNotNull(response.Id);
            Assert.IsNotNull(response.CreatedDate);
            Assert.AreEqual("ACTIVE", response.Status);
            Assert.AreEqual("TRY", response.Currency);
            Assert.AreEqual("WAITING_FOR_PAYOUT", response.PayoutStatus);
        }

        [Test]
        public void Search_Withdraws()
        {
            var request = new SearchWithdrawsRequest
            {
                PayoutStatus = TransactionPayoutStatus.WAITING_FOR_PAYOUT,
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