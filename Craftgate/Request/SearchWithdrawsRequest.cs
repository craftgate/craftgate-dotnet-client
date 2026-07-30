using System;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchWithdrawsRequest : BaseRequest
    {
        public long? MemberId { set; get; }
        public Currency? Currency { set; get; }
        public TransactionPayoutStatus? PayoutStatus { set; get; }
        public decimal? MinWithdrawPrice { set; get; }
        public decimal? MaxWithdrawPrice { set; get; }
        public DateTime? MinCreatedDate { set; get; }
        public DateTime? MaxCreatedDate { set; get; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}