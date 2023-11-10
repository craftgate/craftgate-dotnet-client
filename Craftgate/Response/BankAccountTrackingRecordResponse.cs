using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class BankAccountTrackingRecordResponse
    {
        public long Id { get; set; }
        public string SenderName { get; set; }
        public string SenderIban { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public DateTime RecordDate { get; set; }
        public RecordType RecordType { get; set; }
        public BankAccountTrackingSource BankAccountTrackingSource { get; set; }
    }
}