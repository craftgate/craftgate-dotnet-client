using System;
using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class PayByLinkApiAdapter : BaseAdapter
    {
        public PayByLinkApiAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public ProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            var path = "/craftlink/v1/products";
            return RestClient.Post<ProductResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createProductRequest, path, RequestOptions), createProductRequest);
        }

        public Task<ProductResponse> CreateProductAsync(CreateProductRequest createProductRequest)
        {
            var path = "/craftlink/v1/products";
            return RestClient.PostAsync<ProductResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createProductRequest, path, RequestOptions), createProductRequest);
        }

        public ProductResponse UpdateProduct(long id, UpdateProductRequest updateProductRequest)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.Put<ProductResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateProductRequest, path, RequestOptions), updateProductRequest);
        }

        public Task<ProductResponse> UpdateProductAsync(long id, UpdateProductRequest updateProductRequest)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.PutAsync<ProductResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateProductRequest, path, RequestOptions), updateProductRequest);
        }

        public ProductResponse RetrieveProduct(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.Get<ProductResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task<ProductResponse> RetrieveProductAsync(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.GetAsync<ProductResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public void DeleteProduct(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public Task DeleteProductAsync(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.DeleteAsync<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public ProductListResponse SearchProducts(SearchProductsRequest searchProductsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchProductsRequest);
            String path = "/craftlink/v1/products" + queryParam;
            return RestClient.Get<ProductListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
        
        public Task<ProductListResponse> SearchProductsAsync(SearchProductsRequest searchProductsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchProductsRequest);
            String path = "/craftlink/v1/products" + queryParam;
            return RestClient.GetAsync<ProductListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}