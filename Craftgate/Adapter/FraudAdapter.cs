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

        public void CreateValueList(string listName, FraudValueType type)
        {
            AddValueToValueList(new FraudValueListRequest
            {
                ListName = listName,
                Type = type,
                Value = null,
                DurationInSeconds = null
            });
        }

        public Task CreateValueListAsync(string listName, FraudValueType type)
        {
            return AddValueToValueListAsync(new FraudValueListRequest
            {
                ListName = listName,
                Type = type,
                Value = null,
                DurationInSeconds = null
            });
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

        public void AddValueToValueList(FraudValueListRequest request)
        {
            const string path = "/fraud/v1/value-lists";
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }
        
        public void AddCardFingerprintToFraudValueList(AddCardFingerprintFraudValueListRequest request,string listName)
        {
            string path = "/fraud/v1/value-lists/" + listName + "/card-fingerprints";
            RestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public Task AddValueToValueListAsync(FraudValueListRequest request)
        {
            const string path = "/fraud/v1/value-lists";
            return AsyncRestClient.Post<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(request, path, RequestOptions), request);
        }

        public void RemoveValueFromValueList(string listName, string value)
        {
            var path = "/fraud/v1/value-lists/" + listName + "/values/" + value;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task RemoveValueFromValueListAsync(string listName, string valueId)
        {
            var path = "/fraud/v1/value-lists/" + listName + "/values/" + valueId;
            return AsyncRestClient.Delete<object>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
        
        public FraudRuleListResponse SearchFraudRules(SearchFraudRuleRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/fraud/v1/rules" + queryParam;
            return RestClient.Get<FraudRuleListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
        
        public Task SearchFraudRulesAsync(SearchFraudRuleRequest request)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/fraud/v1/rules" + queryParam;
            return AsyncRestClient.Get<FraudRuleListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}