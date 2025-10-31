using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

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

        public byte[] RetrieveDailyPaymentReport(RetrieveDailyPaymentReportRequest retrieveDailyPaymentReportRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveDailyPaymentReportRequest);
            var path = "/file-reporting/v1/payment-reports" + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return RestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }

        public Task<byte[]> RetrieveDailyPaymentReportAsync(RetrieveDailyPaymentReportRequest retrieveDailyPaymentReportRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveDailyPaymentReportRequest);
            var path = "/file-reporting/v1/payment-reports" + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return AsyncRestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }

        public ReportDemandResponse CreateReport(CreateReportRequest request)
        {
            var path = "/file-reporting/v1/report-demands";
            var headers = CreateHeaders(request, path, RequestOptions);
            return RestClient.Post<ReportDemandResponse>(RequestOptions.BaseUrl + path, headers, request);
        }
        
        public Task<ReportDemandResponse> CreateReportAsync(CreateReportRequest request)
        {
            var path = "/file-reporting/v1/report-demands";
            var headers = CreateHeaders(request, path, RequestOptions);
            return AsyncRestClient.Post<ReportDemandResponse>(RequestOptions.BaseUrl + path, headers, request);
        }

        public byte[] RetrieveReport(RetrieveReportRequest retrieveReportRequest, long reportId)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveReportRequest);
            var path = "/file-reporting/v1/reports/" + reportId + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return RestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }

        public Task<byte[]> RetrieveReportAsync(RetrieveReportRequest retrieveReportRequest, long reportId)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(retrieveReportRequest);
            var path = "/file-reporting/v1/reports/" + reportId + queryParam;
            var headers = CreateHeaders(path, RequestOptions);
            headers.Add(ContentType, ApplicationOctetStream);
            return AsyncRestClient.Get<byte[]>(RequestOptions.BaseUrl + path, headers);
        }
    }
}