using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class SettlementRow
    {
        public long Id { get; set; }
        public long MerchantId { get; set; }
        public MerchantType MerchantType { get; set; }
        public decimal PayoutAmount { get; set; }
        public FileStatus FileStatus { get; set; }
    }
}