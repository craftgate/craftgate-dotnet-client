using System;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class PaymentReportingSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Search_Payments()
        {
            var request = new SearchPaymentsRequest()
            {
                Page = 0,
                Size = 10,
                PaymentId = 100,
                PaymentTransactionId = 1000,
                BuyerMemberId = 1,
                ConversationId = "conversationId",
                ExternalId = "externalId",
                OrderId = "orderId",
                PaymentType = PaymentType.CARD_PAYMENT,
                PaymentStatus = PaymentStatus.SUCCESS,
                BinNumber = "123456",
                LastFourDigits = "1234",
                Currency = Currency.TRY,
                MinPaidPrice = decimal.One,
                MaxPaidPrice = new decimal(100),
                Installment = 1,
                IsThreeDS = false,
                MinCreatedDate = DateTime.Now.AddDays(-30),
                MaxCreatedDate = DateTime.Now,
            };

            var response = _craftgateClient.PaymentReporting().SearchPayments(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Retrieve_Payment()
        {
            long paymentId = 1;

            var response = _craftgateClient.PaymentReporting().RetrievePayment(paymentId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentId, response.Id);
            Assert.NotNull(response.Price);
            Assert.NotNull(response.PaidPrice);
            Assert.NotNull(response.PaymentType);
            Assert.NotNull(response.PaymentStatus);
            Assert.NotNull(response.RefundablePrice);
        }

        [Test]
        public void Retrieve_Payment_Transactions()
        {
            long paymentId = 1;

            var response = _craftgateClient.PaymentReporting().RetrievePaymentTransactions(paymentId);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Retrieve_Payment_Refunds()
        {
            long paymentId = 1;

            var response = _craftgateClient.PaymentReporting().RetrievePaymentRefunds(paymentId);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Retrieve_Payment_Transaction_Refunds()
        {
            long paymentId = 1;
            long paymentTransactionId = 100;

            var response = _craftgateClient.PaymentReporting().RetrievePaymentTransactionRefunds(paymentId, paymentTransactionId);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Payment_Refunds()
        {
            var request = new SearchPaymentRefundsRequest()
            {
                Page = 0,
                Size = 10,
                Id = 1,
                PaymentId = 100,
                BuyerMemberId = 1,
                ConversationId = "conversationId",
                Status = RefundStatus.SUCCESS,
                Currency = Currency.TRY,
                MinRefundPrice = decimal.One,
                MaxRefundPrice = new decimal(100),
                MinCreatedDate = DateTime.Now.AddDays(-30),
                MaxCreatedDate = DateTime.Now,
            };

            var response = _craftgateClient.PaymentReporting().SearchPaymentRefunds(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Payment_Transaction_Refunds()
        {
            var request = new SearchPaymentTransactionRefundsRequest()
            {
                Page = 0,
                Size = 10,
                Id = 1,
                PaymentId = 100,
                PaymentTransactionId = 1000,
                BuyerMemberId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Status = RefundStatus.SUCCESS,
                Currency = Currency.TRY,
                MinRefundPrice = decimal.One,
                MaxRefundPrice = new decimal(100),
                IsAfterSettlement = false,
                MinCreatedDate = DateTime.Now.AddDays(-30),
                MaxCreatedDate = DateTime.Now,
            };

            var response = _craftgateClient.PaymentReporting().SearchPaymentTransactionRefunds(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}