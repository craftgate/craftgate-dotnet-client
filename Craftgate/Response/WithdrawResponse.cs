using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class WithdrawResponse
    {
        public long Id;
        public Status Status;
        public long MemberId;
        public long? PayoutId;
        public decimal Price;
        public DateTime CreatedDate;
        public String Description;
        public Currency Currency;
        public TransactionPayoutStatus PayoutStatus;
    }
}