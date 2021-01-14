using System;
using Craftgate.Model;

namespace Craftgate.Response
{
    public class RemittanceResponse
    {
        public long? Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Status? Status { get; set; }
        public decimal? Price { get; set; }
        public long? MemberId { get; set; }
        public RemittanceType? RemittanceType { get; set; }
        public RemittanceReasonType? RemittanceReasonType { get; set; }
        public string Description { get; set; }
    }
}