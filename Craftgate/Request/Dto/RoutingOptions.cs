using System.Collections.Generic;

namespace Craftgate.Request.Dto
{
    public class RoutingOptions
    {
        public OrderingRule? OrderingRule { get; set; }
        public IList<string> PosAliases { get; set; }
        public bool? IgnoreAdvancedPosRoutingRules { get; set; }
    }

    public enum OrderingRule
    {
        ON_US,
        LOW_COMMISSION_RATE,
        IN_ORDER
    }
}
