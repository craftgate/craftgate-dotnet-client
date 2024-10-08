using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateMerchantApmRequest
    {
        public ApmStatus Status = ApmStatus.ACTIVE;
        public string Name;
        public ApmType ApmType;
        public string Hostname;
        public List<Currency> SupportedCurrencies;
        public Dictionary<string, object> Properties;
    }
}