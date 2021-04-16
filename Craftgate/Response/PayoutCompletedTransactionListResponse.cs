using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PayoutCompletedTransactionListResponse
    {
        public IList<PayoutCompletedTransaction> Items { get; set; }
    }
}