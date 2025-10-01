using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class MerchantApmResponse
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string ApmType { get; set; }
        public string Hostname { get; set; }
        public List<string> SupportedCurrencies { get; set; }
    }
}