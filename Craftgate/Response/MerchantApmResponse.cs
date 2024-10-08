using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class MerchantApmResponse
    {
        public long Id { get; set; }
        public ApmStatus Status { get; set; }
        public string Name { get; set; }
        public ApmType ApmType { get; set; }
        public string Hostname { get; set; }
        public long MerchantId { get; set; }
        public List<Currency> SupportedCurrencies { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
}