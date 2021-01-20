using System.Collections.Generic;
using Craftgate.Request;
using Craftgate.Request.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Test
{
    public class HashGeneratorTest
    {
        [SetUp]
        public void Setup()
        {
            ConfigureJsonConverter();
        }

        [Test]
        public void Should_Generate_Hash()
        {
            //given
            var expectedSignature = "lxoBkNdEanGAXYOL63uz/7P03kB0guaSPl7lXWvRJ4o=";
            var request = new CreateMemberRequest
            {
                MemberExternalId = "ext-1511",
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                Name = "Haluk Demir",
                IdentityNumber = "11111111110"
            };

            //when
            var signature = HashGenerator.GenerateHash("https://api.craftgate.io", "api-key", "secret-key",
                "rand-2010",
                request, "/onboarding/v1/members");

            //then
            Assert.AreEqual(expectedSignature, signature);
        }

        [Test]
        public void Should_Generate_Hash_When_Request_Body_Null()
        {
            //given
            var expectedSignature = "/IoWMs1tQ329eEC4XoDwQAhYc4eHZKV8bdFYNhrL/BQ=";

            //when
            var signature = HashGenerator.GenerateHash("https://api.craftgate.io", "api-key", "secret-key",
                "rand-2010",
                null, "/onboarding/v1/members");

            //then
            Assert.AreEqual(expectedSignature, signature);
        }

        private static void ConfigureJsonConverter()
        {
            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter()
                    }
                };
                return settings;
            };
        }
    }
}