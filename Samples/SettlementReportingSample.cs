using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class SettlementReportingSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Search_Settlement_Payout_Completed_Items()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutCompletedItemsRequest()
            {
                SettlementType = SettlementType.SETTLEMENT,
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 0, 0, 0),
                EndDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 23, 59, 59),
                Page = 0,
                Size = 10
            };

            var response = _craftgateClient.SettlementReporting().SearchPayoutCompletedItems(request);
            Assert.True(response.Items.Count > 0);
            Assert.True(response.Page == 0);
            Assert.True(response.Size == 10);
        }

        [Test]
        public void Search_Bounced_Settlement_Payout_Completed_Items()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutCompletedItemsRequest()
            {
                SettlementType = SettlementType.BOUNCED_SETTLEMENT,
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 0, 0, 0),
                EndDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 23, 59, 59),
                Page = 0,
                Size = 10
            };

            var response = _craftgateClient.SettlementReporting().SearchPayoutCompletedItems(request);
            Assert.True(response.Items.Count > 0);
            Assert.True(response.Page == 0);
            Assert.True(response.Size == 10);
        }

        [Test]
        public void Search_Payout_Bounced_Transactions()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutBouncedTransactionsRequest()
            {
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 0, 0, 0),
                EndDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 23, 59, 59)
            };

            var response = _craftgateClient.SettlementReporting().SearchBouncedPayoutTransactions(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Retrieve_Settlement_Row()
        {
            var settlementRowId = 1L;

            var response = _craftgateClient.SettlementReporting().RetrieveSettlementRow(settlementRowId);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }
        
        [Test]
        public void Search_Payout_Rows()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutRowsRequest()
            {
                Page = 0,
                Size = 10,
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 10, 0, 0, 0),
                EndDate = ts,
                FileStatus = FileStatus.CREATED
            };

            var response = _craftgateClient.SettlementReporting().SearchPayoutRows(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Retrieve_Payment_Transaction_Payout()
        {
            var paymentTransactionId = 1L;

            var response = _craftgateClient.SettlementReporting().RetrievePaymentTransactionPayout(paymentTransactionId);
            Assert.AreEqual(paymentTransactionId, response.PaymentTransactionId);
            Assert.True(response.PayoutItems.Count > 0);
        }

        [Test]
        public void Search_Payment_Transaction_Payouts()
        {
            var request = new SearchPaymentTransactionPayoutsRequest()
            {
                PaymentTransactionIds = new HashSet<long> { 1, 2 }
            };

            var response = _craftgateClient.SettlementReporting().SearchPaymentTransactionPayouts(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}