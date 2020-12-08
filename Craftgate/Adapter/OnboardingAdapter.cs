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

        public MemberListResponse SearchMembers(SearchMemberRequest searchMemberRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchMemberRequest);
            var path = "/onboarding/v1/members" + queryParam;
            return RestClient.Get<MemberListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}