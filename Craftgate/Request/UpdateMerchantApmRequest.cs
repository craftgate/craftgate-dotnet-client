using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateMerchantApmRequest
    {
        public string Name { get; set; }
        public string Hostname { get; set; }
        public ApmStatus Status { get; set; }
        public List<Currency> SupportedCurrencies { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
}