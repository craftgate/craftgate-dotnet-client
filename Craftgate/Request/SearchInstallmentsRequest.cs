using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchInstallmentsRequest
    {
        public string BinNumber { get; set; }
        public decimal? Price { get; set; }
        public Currency? Currency { get; set; }
    }
}