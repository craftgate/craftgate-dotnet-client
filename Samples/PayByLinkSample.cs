using System.Collections.Generic;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Response;
using NUnit.Framework;

namespace Samples
{
    public class PayByLinkSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Create_Product()
        {
            CreateProductRequest request = new CreateProductRequest
            {
                Name = "A new Product",
                Channel = "API",
                Price = 10,
                ConversationId = "my-ConversationId",
                ExternalId = "my-ExternalId",
                Currency = Currency.TRY,
                EnabledInstallments = new HashSet<long> {1, 2, 3, 6}
            };

            ProductResponse response = _craftgateClient.PayByLink().CreateProduct(request);

            Assert.AreEqual(response.Status, Status.ACTIVE);
            Assert.AreEqual(response.Name, request.Name);
            Assert.AreEqual(response.Price, request.Price);
            Assert.AreEqual(response.Channel, request.Channel);
            Assert.AreEqual(response.Currency, request.Currency);
            Assert.AreEqual(response.EnabledInstallments, request.EnabledInstallments);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Token);
        }

        [Test]
        public void Update_Product()
        {
            long productId = 1L;
            UpdateProductRequest request = new UpdateProductRequest
            {
                Status = Status.ACTIVE,
                Name = "A new Product - version 2",
                Channel = "API",
                Price = 10,
                Currency = Currency.TRY,
                EnabledInstallments = new HashSet<long>() {1, 2, 3}
            };

            ProductResponse response = _craftgateClient.PayByLink().UpdateProduct(productId, request);

            Assert.AreEqual(response.Status, request.Status);
            Assert.AreEqual(response.Name, request.Name);
            Assert.AreEqual(response.Price, request.Price);
            Assert.AreEqual(response.Channel, request.Channel);
            Assert.AreEqual(response.Currency, request.Currency);
            Assert.AreEqual(response.EnabledInstallments, request.EnabledInstallments);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Token);
        }

        [Test]
        public void Retrieve_Product()
        {
            long productId = 1L;
            ProductResponse response = _craftgateClient.PayByLink().RetrieveProduct(productId);

            Assert.AreEqual(productId, response.Id);
            Assert.NotNull(response.Name);
            Assert.NotNull(response.Price);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Token);
        }

        [Test]
        public void Delete_Product()
        {
            long productId = 1;
            _craftgateClient.PayByLink().DeleteProduct(productId);
        }

        [Test]
        public void Search_Products()
        {
            SearchProductsRequest request = new SearchProductsRequest
            {
                Name = "A new Product",
                Channel = "API",
                Currency = Currency.TRY
            };

            ProductListResponse productListResponse = _craftgateClient.PayByLink().SearchProducts(request);

            Assert.NotNull(productListResponse);
        }
    }
}