using System.Threading.Tasks;
using Craftgate.Model;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class FraudAdapter : BaseAdapter
    {
        public FraudAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public FraudCheckListResponse SearchFraudChecks(SearchFraudChecksRequest searchFraudChecksRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchFraudChecksRequest);
            var path = "/fraud/v1/fraud-checks" + queryParam;
            return RestClient.Get<FraudCheckListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<FraudCheckListResponse> SearchFraudChecksAsync(SearchFraudChecksRequest searchFraudChecksRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchFraudChecksRequest);
            var path = "/fraud/v1/fraud-checks" + queryParam;
            return AsyncRestClient.Get<FraudCheckListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void UpdateFraudCheckStatus(long id, FraudCheckStatus fraudCheckStatus)
        {
            var path = "/fraud/v1/fraud-checks/" + id + "/check-status";
            var request = new UpdateFraudCheckStatusRequest(fraudCheckStatus);
            RestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task UpdateFraudCheckStatusAsync(long id, FraudCheckStatus fraudCheckStatus)
        {
            var path = "/fraud/v1/fraud-checks/" + id + "/check-status";
            var request = new UpdateFraudCheckStatusRequest(fraudCheckStatus);
            return AsyncRestClient.Put<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public FraudAllValueListsResponse RetrieveAllValueLists()
        {
            const string path = "/fraud/v1/value-lists/all";
            return RestClient.Get<FraudAllValueListsResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<FraudAllValueListsResponse> RetrieveAllValueListsAsync()
        {
            const string path = "/fraud/v1/value-lists/all";
            return AsyncRestClient.Get<FraudAllValueListsResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public FraudValueListResponse RetrieveValueList(string listName)
        {
            var path = "/fraud/v1/value-lists/" + listName;
            return RestClient.Get<FraudValueListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<FraudValueListResponse> RetrieveValueListAsync(string listName)
        {
            var path = "/fraud/v1/value-lists/" + listName;
            return AsyncRestClient.Get<FraudValueListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void CreateValueList(string listName)
        {
            AddValueToValueList(listName, null, null);
        }

        public Task CreateValueListAsync(string listName)
        {
            return AddValueToValueListAsync(listName, null, null);
        }

        public void DeleteValueList(string listName)
        {
            var path = "/fraud/v1/value-lists/" + listName;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task DeleteValueListAsync(string listName)
        {
            var path = "/fraud/v1/value-lists/" + listName;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void AddValueToValueList(string listName, string value, int? expireInSeconds)
        {
            const string path = "/fraud/v1/value-lists";
            var request = new FraudValueListRequest
            {
                ListName = listName,
                Value = value,
                DurationInSeconds = expireInSeconds
            };
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task AddValueToValueListAsync(string listName, string value, int? expireInSeconds)
        {
            const string path = "/fraud/v1/value-lists";
            var request = new FraudValueListRequest
            {
                ListName = listName,
                Value = value,
                DurationInSeconds = expireInSeconds
            };
            return AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public void RemoveValueFromValueList(string listName, string value)
        {
            var path = "/fraud/v1/value-lists/" + listName + "/values/" + value;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task RemoveValueFromValueListAsync(string listName, string value)
        {
            var path = "/fraud/v1/value-lists/" + listName + "/values/" + value;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}