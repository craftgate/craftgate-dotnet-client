using System;
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

        public ProductResponse UpdateProduct(long id, UpdateProductRequest updateProductRequest)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.Put<ProductResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateProductRequest, path, RequestOptions), updateProductRequest);
        }

        public ProductResponse RetrieveProduct(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            return RestClient.Get<ProductResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public void DeleteProduct(long id)
        {
            var path = "/craftlink/v1/products/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public ProductListResponse SearchProducts(SearchProductsRequest searchProductsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchProductsRequest);
            String path = "/craftlink/v1/products" + queryParam;
            return RestClient.Get<ProductListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            var path = "/onboarding/v1/members";
            return RestClient.Post<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMemberRequest, path, RequestOptions),
                createMemberRequest);
        }

        public MemberResponse UpdateMember(long id, UpdateMemberRequest updateMemberRequest)
        {
            var path = "/onboarding/v1/members/" + id;
            return RestClient.Put<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMemberRequest, path, RequestOptions),
                updateMemberRequest);
        }

        public MemberResponse RetrieveMember(long id)
        {
            var path = "/onboarding/v1/members/" + id;
            return RestClient.Get<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MemberListResponse SearchMembers(SearchMembersRequest searchMembersRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMembersRequest);
            var path = "/onboarding/v1/members" + queryParam;
            return RestClient.Get<MemberListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}