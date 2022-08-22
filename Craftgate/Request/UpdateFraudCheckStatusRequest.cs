using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateFraudCheckStatusRequest
    {
        public UpdateFraudCheckStatusRequest(FraudCheckStatus fraudCheckStatus) => CheckStatus = fraudCheckStatus;
        public FraudCheckStatus? CheckStatus { get; set; }
    }
}