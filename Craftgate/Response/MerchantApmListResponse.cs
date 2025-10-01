using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class MerchantApmListResponse
    {
        public IList<MerchantApmResponse> Items { get; set; }
    }
}