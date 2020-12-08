using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchInstallmentsRequest
    {
        public string BinNumber { get; set; }
        public decimal? Price { get; set; }
        public Currency? Currency { get; set; }
    }
}