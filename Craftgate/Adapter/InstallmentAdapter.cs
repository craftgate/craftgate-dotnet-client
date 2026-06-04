using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class InstallmentAdapter : BaseAdapter
    {
        public InstallmentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public InstallmentListResponse SearchInstallments(SearchInstallmentsRequest searchInstallmentsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchInstallmentsRequest);
            var path = "/installment/v1/installments" + queryParam;
            return RestClient.Get<InstallmentListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<InstallmentListResponse> SearchInstallmentsAsync(SearchInstallmentsRequest searchInstallmentsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchInstallmentsRequest);
            var path = "/installment/v1/installments" + queryParam;
            return AsyncRestClient.Get<InstallmentListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public BinNumberResponse RetrieveBinNumber(string binNumber, bool includeGlobalBins = false)
        {
            var path = "/installment/v1/bins/" + binNumber + (includeGlobalBins ? "?includeGlobalBins=true" : "");
            return RestClient.Get<BinNumberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<BinNumberResponse> RetrieveBinNumberAsync(string binNumber, bool includeGlobalBins = false)
        {
            var path = "/installment/v1/bins/" + binNumber + (includeGlobalBins ? "?includeGlobalBins=true" : "");
            return AsyncRestClient.Get<BinNumberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}