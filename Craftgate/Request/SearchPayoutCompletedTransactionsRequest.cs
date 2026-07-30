using System;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPayoutCompletedTransactionsRequest : BaseRequest
    {
        public long? SettlementFileId { get; set; }
        public SettlementType? SettlementType { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }
    }
}