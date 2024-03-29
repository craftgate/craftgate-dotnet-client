using Craftgate.Request;
using Craftgate.Request.Common;
using NUnit.Framework;

namespace Test
{
    public class HashGeneratorTest
    {
        [Test]
        public void Should_Generate_Hash()
        {
            //given
            var expectedSignature = "9guTlRNDTRRyUsfSyJ8N/gAdNgQgUsL1guzqgG+FzN4=";
            var request = new CreateMemberRequest
            {
                MemberExternalId = "ext-1511",
                Email = "haluk.demir@example.com",
                PhoneNumber = "905551111111",
                Name = "Haluk Demir",
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
    }
}