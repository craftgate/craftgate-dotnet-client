using Craftgate.Model;

namespace Craftgate.Request
{
    public class RetrieveCardFromIvrRequest
    {
        public string CardUserKey { get; set; }
        public string CallToken { get; set; }
    }
}