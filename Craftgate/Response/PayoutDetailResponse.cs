using System;
using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class PayoutDetailResponse
    {
        public string RowDescription;
        public DateTime PayoutDate;
        public string Name;
        public string Iban;
        public decimal PayoutAmount;
        public string Currency;
        public long MerchantId;
        public string MerchantType;
        public string SettlementEarningsDestination;
        public string SettlementSource;
        public string BounceStatus;
        public IList<PayoutDetailTransaction> PayoutTransactions;
    }
}