using System.Threading.Tasks;
using Craftgate.Net;
using Craftgate.Request.Common;
using Craftgate.Response;

namespace Craftgate.Adapter
{
    public class MerchantApmAdapter : BaseAdapter
    {
        public MerchantApmAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public MerchantApmListResponse RetrieveApms()
        {
            var path = "/merchant/v1/merchant-apms";
            return RestClient.Get<MerchantApmListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public Task<MerchantApmListResponse> RetrieveApmsAsync()
        {
            var path = "/merchant/v1/merchant-apms";
            return AsyncRestClient.Get<MerchantApmListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}