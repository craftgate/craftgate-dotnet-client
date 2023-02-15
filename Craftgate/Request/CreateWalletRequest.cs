using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateWalletRequest
    {
        public decimal? NegativeAmountLimit { get; set; }
        public Currency Currency { get; set; }
    }
}