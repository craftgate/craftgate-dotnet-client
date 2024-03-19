using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchPayoutCompletedTransactionsRequest
    {
        public long? SettlementFileId { get; set; }
        public SettlementType? SettlementType { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int? Page { get; set; } = 0;
        public int? Size { get; set; } = 10;
    }
}