using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RemoveValueFromValueListRequest : BaseRequest
    {
        public string ListName { get; set; }
        public string ValueId { get; set; }
    }
}
