using System;
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
        public void Search_Settlement_Payout_Completed_Transactions()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutCompletedTransactionsRequest()
            {
                SettlementType = SettlementType.SETTLEMENT,
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 0, 0, 0),
                EndDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 23, 59, 59)
            };

            var response = _craftgateClient.SettlementReporting().SearchPayoutCompletedTransactions(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Bounced_Settlement_Payout_Completed_Transactions()
        {
            var ts = DateTime.Now;
            var request = new SearchPayoutCompletedTransactionsRequest()
            {
                SettlementType = SettlementType.BOUNCED_SETTLEMENT,
                StartDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 0, 0, 0),
                EndDate = new DateTime(ts.Year, ts.Month, ts.Day - 1, 23, 59, 59)
            };

            var response = _craftgateClient.SettlementReporting().SearchPayoutCompletedTransactions(request);
            Assert.True(response.Items.Count > 0);
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
        public void Retrieve_Payout_Details()
        {
            var payoutId = 1L;

            var response = _craftgateClient.SettlementReporting().RetrievePayoutDetails(payoutId);
            Assert.NotNull(response);
        }
    }
}