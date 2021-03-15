using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class WithdrawResponse
    {
        public long Id;
        public Status Status;
        public long MemberId;
        public decimal Price;
        public DateTime CreatedDate;
        public String Description;
        public Currency Currency;
        public PayoutStatus PayoutStatus;
    }
}