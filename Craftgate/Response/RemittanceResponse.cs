using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class RemittanceResponse
    {
        public long? Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Status { get; set; }
        public decimal? Price { get; set; }
        public Currency? Currency { get; set; }
        public long? MemberId { get; set; }
        public string RemittanceType { get; set; }
        public string RemittanceReasonType { get; set; }
        public string Description { get; set; }
    }
}