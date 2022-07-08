using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class OnboardingAdapter : BaseAdapter
    {
        public OnboardingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public MemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            var path = "/onboarding/v1/members";
            return RestClient.Post<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createMemberRequest, path, RequestOptions),
                createMemberRequest);
        }

        public Task<MemberResponse> CreateMemberAsync(CreateMemberRequest createMemberRequest)
        {
            var path = "/onboarding/v1/members";
            return AsyncRestClient.Post<MemberResponse>(RequestOptions.BaseUrl + path,
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

        public Task<MemberResponse> UpdateMemberAsync(long id, UpdateMemberRequest updateMemberRequest)
        {
            var path = "/onboarding/v1/members/" + id;
            return AsyncRestClient.Put<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateMemberRequest, path, RequestOptions),
                updateMemberRequest);
        }

        public MemberResponse RetrieveMember(long id)
        {
            var path = "/onboarding/v1/members/" + id;
            return RestClient.Get<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MemberResponse> RetrieveMemberAsync(long id)
        {
            var path = "/onboarding/v1/members/" + id;
            return AsyncRestClient.Get<MemberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public MemberListResponse SearchMembers(SearchMembersRequest searchMembersRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMembersRequest);
            var path = "/onboarding/v1/members" + queryParam;
            return RestClient.Get<MemberListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MemberListResponse> SearchMembersAsync(SearchMembersRequest searchMembersRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMembersRequest);
            var path = "/onboarding/v1/members" + queryParam;
            return AsyncRestClient.Get<MemberListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}