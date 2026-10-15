using System;
using System.Collections.Generic;
using Craftgate.Adapter;
using Craftgate.Common;
using Craftgate.Request;
using Craftgate.Request.Common;
using NUnit.Framework;

namespace Test
{
    public class ClientVersionTest
    {
        private const string ClientVersionHeaderName = "x-client-version";

        private static readonly RequestOptions Options = new RequestOptions
        {
            ApiKey = "api-key",
            SecretKey = "secret-key",
            BaseUrl = "https://sandbox-api.craftgate.io"
        };

        // The release dry run builds with -p:Version and sets this; plain builds have no version.
        private static readonly string ExpectedVersion =
            Environment.GetEnvironmentVariable("CRAFTGATE_EXPECTED_VERSION") ?? "unknown";

        private class TestAdapter : BaseAdapter
        {
            public TestAdapter(RequestOptions requestOptions) : base(requestOptions)
            {
            }

            public Dictionary<string, string> Headers(BaseRequest request, string path) =>
                CreateHeaders(request, path, Options);
        }

        [Test]
        public void Should_Read_Client_Version_From_Build()
        {
            Assert.AreEqual(ExpectedVersion, ClientVersion.Value);
        }

        [Test]
        public void Should_Send_Client_Version_Header()
        {
            //given
            var request = new DeleteStoredCardRequest {CardToken = "card-token"};

            //when
            var headers = new TestAdapter(Options).Headers(request, "/payment/v1/cards/delete");

            //then
            Assert.AreEqual("craftgate-dotnet-client:" + ExpectedVersion, headers[ClientVersionHeaderName]);
        }
    }
}
