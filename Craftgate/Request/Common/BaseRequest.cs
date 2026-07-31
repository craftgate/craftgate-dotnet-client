using Newtonsoft.Json;

namespace Craftgate.Request.Common
{
    public abstract class BaseRequest
    {
        [JsonIgnore]
        public string IdempotencyKey { get; set; }

        public HeaderOptions ToHeaderOptions()
        {
            return new HeaderOptions {IdempotencyKey = IdempotencyKey};
        }
    }
}
