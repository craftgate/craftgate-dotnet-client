using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class FraudValueListResponse
    {
        public string Name { get; set; }
        public List<FraudValue> Values { get; set; }
    }
}