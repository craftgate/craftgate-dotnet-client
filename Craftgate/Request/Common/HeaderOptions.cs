namespace Craftgate.Request.Common
{
    /// <summary>
    /// Carries the request-scoped options that travel as headers rather than in the payload. A
    /// distinct type from <see cref="BaseRequest"/> so the header layer cannot reach path variables
    /// or body fields, and from <see cref="RequestOptions"/>, which holds client configuration.
    /// </summary>
    public class HeaderOptions
    {
        public string IdempotencyKey { get; set; }
    }
}
