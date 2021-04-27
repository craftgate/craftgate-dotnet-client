using System;

namespace Craftgate.Request
{
    public class SearchPayoutBouncedTransactionsRequest
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}