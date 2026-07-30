using System.Collections.Generic;
using Craftgate.Adapter;
using Craftgate.Common;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Common;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Test
{
    public class IdempotencyTest
    {
        private const string IdempotencyKeyHeaderName = "x-idempotency-key";
        private const string SignatureHeaderName = "x-signature";
        private const string RandomHeaderName = "x-rnd-key";

        private static readonly RequestOptions Options = new RequestOptions
        {
            ApiKey = "api-key",
            SecretKey = "secret-key",
            BaseUrl = "https://sandbox-api.craftgate.io"
        };

        /// <summary>Exposes the protected header builders for testing.</summary>
        private class TestAdapter : BaseAdapter
        {
            public TestAdapter(RequestOptions requestOptions) : base(requestOptions)
            {
            }

            public Dictionary<string, string> Headers(object request, string path) =>
                CreateHeaders(request, path, Options);

            public Dictionary<string, string> PathOnlyHeaders(string path, BaseRequest request) =>
                CreateHeadersForPathOnlyRequest(path, Options, request);
        }

        private readonly TestAdapter _adapter = new TestAdapter(Options);

        [Test]
        public void Should_Send_Idempotency_Key_Header_For_Body_Request()
        {
            //given
            var request = new DeleteStoredCardRequest {CardToken = "card-token", IdempotencyKey = "idempotency-key-1"};

            //when
            var headers = _adapter.Headers(request, "/payment/v1/cards/delete");

            //then
            Assert.AreEqual("idempotency-key-1", headers[IdempotencyKeyHeaderName]);
        }

        [Test]
        public void Should_Not_Send_Idempotency_Key_Header_When_Not_Set()
        {
            //given
            var request = new DeleteStoredCardRequest {CardToken = "card-token"};

            //when
            var headers = _adapter.Headers(request, "/payment/v1/cards/delete");

            //then
            Assert.IsFalse(headers.ContainsKey(IdempotencyKeyHeaderName));
        }

        [Test]
        public void Should_Send_Idempotency_Key_Header_For_Path_Only_Request()
        {
            //given
            var request = new ExpireCheckoutPaymentRequest {Token = "token-1", IdempotencyKey = "idempotency-key-1"};

            //when
            var headers = _adapter.PathOnlyHeaders("/payment/v1/checkout-payments/token-1", request);

            //then
            Assert.AreEqual("idempotency-key-1", headers[IdempotencyKeyHeaderName]);
        }

        [Test]
        public void Should_Not_Send_Idempotency_Key_Header_For_Path_Only_Request_When_Not_Set()
        {
            //given
            var request = new ExpireCheckoutPaymentRequest {Token = "token-1"};

            //when
            var headers = _adapter.PathOnlyHeaders("/payment/v1/checkout-payments/token-1", request);

            //then
            Assert.IsFalse(headers.ContainsKey(IdempotencyKeyHeaderName));
        }

        [Test]
        public void Should_Exclude_Idempotency_Key_From_Request_Body()
        {
            //given
            var request = new DeleteStoredCardRequest {CardToken = "card-token", IdempotencyKey = "idempotency-key-1"};

            //when
            var body = JsonConvert.SerializeObject(request, CraftgateJsonSerializerSettings.RequestSettings);

            //then
            Assert.IsTrue(body.Contains("card-token"));
            Assert.IsFalse(body.Contains("idempotencyKey"));
            Assert.IsFalse(body.Contains("idempotency-key-1"));
        }

        [Test]
        public void Should_Exclude_Idempotency_Key_From_Query_Params_Of_Read_Requests()
        {
            //given
            var request = new SearchProductsRequest {Name = "A new Product", IdempotencyKey = "idempotency-key-1"};

            //when
            var query = RequestQueryParamsBuilder.BuildQueryParam(request);

            //then
            Assert.IsTrue(query.Contains("name="));
            Assert.IsFalse(query.Contains("idempotencyKey"));
            Assert.IsFalse(query.Contains("idempotency-key-1"));
        }

        /// <summary>A regression here rejects every delete/approve/cancel call at the API.</summary>
        [Test]
        public void Should_Not_Change_Signature_Of_Path_Only_Request()
        {
            //given
            const string path = "/payment/v1/checkout-payments/token-1";
            var request = new ExpireCheckoutPaymentRequest {Token = "token-1", IdempotencyKey = "idempotency-key-1"};

            //when
            var headers = _adapter.PathOnlyHeaders(path, request);

            //then the signature matches a body-less hash over the same random key
            var expected = HashGenerator.GenerateHash(Options.BaseUrl, Options.ApiKey, Options.SecretKey,
                headers[RandomHeaderName], null, path);
            Assert.AreEqual(expected, headers[SignatureHeaderName]);
        }

        [Test]
        public void Should_Not_Change_Signature_Of_Body_Request()
        {
            //given
            const string path = "/payment/v1/cards/delete";
            var request = new DeleteStoredCardRequest {CardToken = "card-token", IdempotencyKey = "idempotency-key-1"};

            //when
            var headers = _adapter.Headers(request, path);

            //then the signature matches the same request without a key
            var withoutKey = new DeleteStoredCardRequest {CardToken = "card-token"};
            var expected = HashGenerator.GenerateHash(Options.BaseUrl, Options.ApiKey, Options.SecretKey,
                headers[RandomHeaderName], withoutKey, path);
            Assert.AreEqual(expected, headers[SignatureHeaderName]);
        }

        [Test]
        public void Should_Carry_Path_Variables_On_Wrappers()
        {
            //given
            var removeValue = new RemoveValueFromValueListRequest
                {ListName = "ipList", ValueId = "value-1", IdempotencyKey = "idempotency-key-1"};
            var posStatus = new UpdateMerchantPosStatusRequest
                {MerchantPosId = 1, PosStatus = PosStatus.PASSIVE, IdempotencyKey = "idempotency-key-2"};
            var fraudCheck = new UpdateFraudCheckStatusRequest
                {Id = 2613, CheckStatus = FraudCheckStatus.FRAUD, IdempotencyKey = "idempotency-key-3"};

            //then
            Assert.AreEqual("ipList", removeValue.ListName);
            Assert.AreEqual("value-1", removeValue.ValueId);
            Assert.AreEqual("idempotency-key-1", removeValue.IdempotencyKey);

            Assert.AreEqual(1, posStatus.MerchantPosId);
            Assert.AreEqual(PosStatus.PASSIVE, posStatus.PosStatus);
            Assert.AreEqual("idempotency-key-2", posStatus.IdempotencyKey);

            Assert.AreEqual(2613, fraudCheck.Id);
            Assert.AreEqual(FraudCheckStatus.FRAUD, fraudCheck.CheckStatus);
            Assert.AreEqual("idempotency-key-3", fraudCheck.IdempotencyKey);
        }

        /// <summary>The class doubles as the body, so its path variable must not reach it.</summary>
        [Test]
        public void Should_Exclude_Fraud_Check_Id_From_Request_Body()
        {
            //given
            var request = new UpdateFraudCheckStatusRequest
                {Id = 2613, CheckStatus = FraudCheckStatus.FRAUD, IdempotencyKey = "idempotency-key-1"};

            //when
            var body = JsonConvert.SerializeObject(request, CraftgateJsonSerializerSettings.RequestSettings);

            //then
            Assert.AreEqual("{\"checkStatus\":\"FRAUD\"}", body);
        }
    }
}
