using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;

namespace Craftgate.Adapter
{
    public class FileReportingAdapter : BaseAdapter
    {
        private const string ContentType = "Content-Type";
        private const string ApplicationOctetStream = "application/octet-stream";

        public FileReportingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public byte[] RetrieveDailyTransactionReport(RetrieveDailyTransactionReportRequest retrieveDailyTransactionReportRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveDailyTransactionReportRequest);
            var path = "/file-reporting/v1/transaction-reports" + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return RestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }
        
        public Task<byte[]> RetrieveDailyTransactionReportAsync(RetrieveDailyTransactionReportRequest retrieveDailyTransactionReportRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveDailyTransactionReportRequest);
            var path = "/file-reporting/v1/transaction-reports" + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return AsyncRestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }
    }
}