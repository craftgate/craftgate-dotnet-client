using System;
using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class BankAccountTrackingSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Search_Bank_Account_Tracking_Records()
        {
            var request = new SearchBankAccountTrackingRecordsRequest()
            {
                Currency = Currency.TRY,
                Page = 0,
                Size = 10
            };

            var response = _craftgateClient.BankAccountTracking().SearchRecords(request);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }
    }
}