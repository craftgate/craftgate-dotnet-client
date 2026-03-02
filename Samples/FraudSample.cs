using System;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class FraudSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");
        
        [Test]
        public void Search_Fraud_Checks()
        {
            var request = new SearchFraudChecksRequest()
            {
                MinCreatedDate = DateTime.Now.AddDays(-1),
                MaxCreatedDate = DateTime.Now,
                Action = FraudAction.REVIEW,
                CheckStatus = FraudCheckStatus.WAITING
            };

            var response = _craftgateClient.Fraud().SearchFraudChecks(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Search_Fraud_Checks_With_Payment()
        {
            var request = new SearchFraudChecksRequest()
            {
               PaymentId = 5L
            };

            var response = _craftgateClient.Fraud().SearchFraudChecks(request);
            Assert.True(response.Items.Count > 0);
        }
        
        [Test]
        public void Update_Fraud_Check_Status()
        {
            const long fraudCheckId = 1L;
            _craftgateClient.Fraud().UpdateFraudCheckStatus(fraudCheckId, FraudCheckStatus.FRAUD);
        }
        
        [Test]
        public void Retrieve_Fraud_Value_List()
        {
            var response = _craftgateClient.Fraud().RetrieveValueList("ipList");
            Assert.AreEqual(response.Name, "ipList");
        }
        
        [Test]
        public void Retrieve_All_Fraud_Value_Lists()
        {
            var response = _craftgateClient.Fraud().RetrieveAllValueLists();
            Assert.True(response.Items.Count > 0);
        }
        
        [Test]
        public void Create_Fraud_Value_List()
        {
            _craftgateClient.Fraud().CreateValueList("ipList", FraudValueType.IP);
        }
        
        [Test]
        public void Add_Value_To_Fraud_Value_List()
        {
            var request = new FraudValueListRequest
            {
                ListName = "ipList",
                Type = FraudValueType.IP,
                Label = "local ip 1",
                Value = "127.0.0.1"
            };
            
            _craftgateClient.Fraud().AddValueToValueList(request);
        }

        [Test]
        public void Add_Card_Value_To_Fraud_Value_List()
        {
            var request = new AddCardFingerprintFraudValueListRequest
            {
                Label = "John Doe's Card",
                Operation = FraudOperation.PAYMENT,
                OperationId = "11675", // PaymentId
                DurationInSeconds = 3600
            };

            _craftgateClient.Fraud().AddCardFingerprintToFraudValueList(request, "cardList");
        }
        
        [Test]
        public void Add_Temporary_Value_To_Fraud_Value_List()
        {
            var request = new FraudValueListRequest
            {
                ListName = "ipList",
                Type = FraudValueType.IP,
                Label = "local ip 2",
                Value = "127.0.0.2",
                DurationInSeconds = 60
            };

            _craftgateClient.Fraud().AddValueToValueList(request);
        }
        
        [Test]
        public void Remove_Value_From_Fraud_Value_List()
        {
            _craftgateClient.Fraud().RemoveValueFromValueList("ipList", "9bf6d4de-59ee-48c1-8404-374999ab1a4e");
        }
        
        [Test]
        public void Delete_Value_List()
        {
            _craftgateClient.Fraud().DeleteValueList("ipList");
        }
        
        [Test]
        public void Search_Fraud_Rules()
        {
            var request = new SearchFraudRuleRequest()
            {
                Action = FraudAction.REVIEW
            };

            var response = _craftgateClient.Fraud().SearchFraudRules(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}