using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class CheckMasterpassUserRequest : BaseRequest
    {
        public string MasterpassGsmNumber { get; set; }
    }
}