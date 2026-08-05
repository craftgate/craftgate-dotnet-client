using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class DeleteProductRequest : BaseRequest
    {
        public long? Id { get; set; }
    }
}
