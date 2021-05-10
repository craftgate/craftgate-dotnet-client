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
        public MerchantType MerchantType;
        public SettlementEarningsDestination SettlementEarningsDestination;
        public SettlementSource SettlementSource;
        public IList<PayoutDetailTransaction> PayoutTransactions;
    }
}