using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using NUnit.Framework;

namespace Samples
{
    public class MealVoucherCardTokenizationSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Init_Meal_Voucher_Card_Tokenization()
        {
            var request = new MealVoucherCardTokenizationInitRequest
            {
                ApmType = ApmType.SETCARD,
                MealVoucherCardTokenizationData = new MealVoucherCardTokenizationData
                {
                    CallbackUrl = "https://webhook.site/e806070a-da76-4d02-a67b-54ba9e8332d3"
                }
            };

            var response = _craftgateClient.MealVoucherCardTokenization().InitMealVoucherCardTokenization(request);

            Assert.NotNull(response.SessionId);
            Assert.AreEqual(ApmAdditionalAction.SHOW_HTML_CONTENT, response.AdditionalAction);
            Assert.NotNull(response.HtmlContent);
        }

        [Test]
        public void Regenerate_Meal_Voucher_Card_Tokenization()
        {
            var sessionId = "sessionId";
            var request = new MealVoucherCardTokenizationRegenerateRequest
            {
                MealVoucherCardTokenizationData = new MealVoucherCardTokenizationData
                {
                    CallbackUrl = "https://www.yourdomain.com/callback"
                }
            };

            var response = _craftgateClient.MealVoucherCardTokenization().RegenerateMealVoucherCardTokenization(sessionId, request);

            Assert.NotNull(response.SessionId);
        }

        [Test]
        public void Complete_Meal_Voucher_Card_Tokenization()
        {
            var sessionId = "sessionId";
            var request = new MealVoucherCardTokenizationCompleteRequest
            {
                ValidationCode = "123456"
            };

            var response = _craftgateClient.MealVoucherCardTokenization().CompleteMealVoucherCardTokenization(sessionId, request);

            Assert.NotNull(response.SessionId);
            Assert.NotNull(response.MaskedCardNumber);
            Assert.NotNull(response.Fingerprint);
        }
    }
}
