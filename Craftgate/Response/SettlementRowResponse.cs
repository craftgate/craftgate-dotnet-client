using System;
using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class SettlementRowResponse
    {
        public string RowDescription { get; set; }
        public DateTime? PayoutDate { get; set; }
        public string Name { get; set; }
        public string Iban { get; set; }
        public decimal PayoutAmount { get; set; }
        public string Currency { get; set; }
        public string MerchantType { get; set; }
        public long MerchantId { get; set; }
        public string SettlementEarningsDestination { get; set; }
        public string SettlementSource { get; set; }
        public string BounceStatus { get; set; }
        public IList<SettlementRowItem> Items { get; set; }
    }
}