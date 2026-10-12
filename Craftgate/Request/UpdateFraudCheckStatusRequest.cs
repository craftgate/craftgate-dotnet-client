using System;
using Craftgate.Model;
using Craftgate.Request.Common;
using Newtonsoft.Json;

namespace Craftgate.Request
{
    public class UpdateFraudCheckStatusRequest : BaseRequest
    {
        [JsonIgnore]
        public long? Id { get; set; }

        public FraudCheckStatus? CheckStatus { get; set; }
    }
}