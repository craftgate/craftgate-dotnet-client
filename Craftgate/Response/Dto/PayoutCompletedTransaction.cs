using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class PayoutCompletedTransaction
    {
        public long PayoutId;
        public long TransactionId;
        public string TransactionType;
        public decimal PayoutAmount;
        public string Currency;
        public long MerchantId;
        public MerchantType MerchantType;
        public SettlementEarningsDestination SettlementEarningsDestination;
        public SettlementSource SettlementSource;
    }
}