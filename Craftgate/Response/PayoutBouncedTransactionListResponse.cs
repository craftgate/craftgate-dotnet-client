using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PayoutBouncedTransactionListResponse
    {
        public IList<PayoutBouncedTransaction> Items { get; set; }
    }
}