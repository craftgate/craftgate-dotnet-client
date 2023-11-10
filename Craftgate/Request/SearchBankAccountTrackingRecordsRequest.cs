using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchBankAccountTrackingRecordsRequest
    {
        public string SenderName { get; set; }
        public string SenderIban { get; set; }
        public string Description { get; set; }
        public Currency? Currency { get; set; }
        public DateTime? MinRecordDate { get; set; }
        public DateTime? MaxRecordDate { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}