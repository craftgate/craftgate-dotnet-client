using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PayoutCompletedTransactionListResponse
    {
        public IList<PayoutCompletedTransaction> Items { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }
        public long? TotalSize { get; set; }
    }
}