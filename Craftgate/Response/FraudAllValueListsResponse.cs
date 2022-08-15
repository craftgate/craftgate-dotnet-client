using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class FraudAllValueListsResponse
    {
        public IList<FraudValueListResponse> Items { get; set; }
    }
}