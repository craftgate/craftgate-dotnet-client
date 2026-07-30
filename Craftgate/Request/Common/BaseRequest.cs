using Newtonsoft.Json;

namespace Craftgate.Request.Common
{
    /// <summary>
    /// Base class for request objects sent to the Craftgate API. Properties here are
    /// <see cref="JsonIgnoreAttribute"/>-marked, which keeps them out of the body, the signature
    /// and the query string.
    /// </summary>
    public abstract class BaseRequest
    {
        /// <summary>
        /// Optional key, sent as the <c>x-idempotency-key</c> header so a mutating call can be
        /// safely retried.
        /// </summary>
        [JsonIgnore]
        public string IdempotencyKey { get; set; }
    }
}
