using Newtonsoft.Json;

namespace Craftgate.Request.Common
{
    public abstract class BaseRequest
    {
        [JsonIgnore]
        public HeaderOptions HeaderOptions { get; set; }
    }
}
