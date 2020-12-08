namespace Craftgate.Response.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public ErrorResponse Errors { get; set; }
    }
}