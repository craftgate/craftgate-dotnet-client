using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class FraudRule
    {
        public long Id { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
        public FraudAction Action { get; set; }
        public string Conditions { get; set; }
        public IList<string> Operations { get; set; }
    }
}