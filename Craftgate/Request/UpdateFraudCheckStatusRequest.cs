using System;
using Craftgate.Model;
using Craftgate.Request.Common;
using Newtonsoft.Json;

namespace Craftgate.Request
{
    public class UpdateFraudCheckStatusRequest : BaseRequest
    {
        public UpdateFraudCheckStatusRequest()
        {
        }

        public UpdateFraudCheckStatusRequest(FraudCheckStatus fraudCheckStatus) => CheckStatus = fraudCheckStatus;

        [JsonIgnore]
        public long? Id { get; set; }

        public FraudCheckStatus? CheckStatus { get; set; }
    }
}