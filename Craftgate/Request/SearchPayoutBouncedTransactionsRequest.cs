using System;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPayoutBouncedTransactionsRequest : BaseRequest
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}