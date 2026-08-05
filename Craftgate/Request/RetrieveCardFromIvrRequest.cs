using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RetrieveCardFromIvrRequest : BaseRequest
    {
        public string CardUserKey { get; set; }
        public string CallToken { get; set; }
    }
}