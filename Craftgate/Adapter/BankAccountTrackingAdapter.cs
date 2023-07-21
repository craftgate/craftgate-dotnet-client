using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;
using Craftgate.Response.Dto;

namespace Craftgate.Adapter
{
    public class BankAccountTrackingAdapter : BaseAdapter
    {
        public BankAccountTrackingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public BankAccountTrackingRecordListResponse SearchRecords(SearchBankAccountTrackingRecordsRequest request)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/bank-account-tracking/v1/merchant-bank-account-trackings/records" + query;

            return RestClient.Get<BankAccountTrackingRecordListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<BankAccountTrackingRecordListResponse> SearchRecordsAsync(SearchBankAccountTrackingRecordsRequest request)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(request);
            var path = "/bank-account-tracking/v1/merchant-bank-account-trackings/records" + query;

            return AsyncRestClient.Get<BankAccountTrackingRecordListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}