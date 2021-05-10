using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class PayoutDetailTransaction
    {
        public long TransactionId;
        public string TransactionType;
        public decimal PayoutAmount;
    }
}