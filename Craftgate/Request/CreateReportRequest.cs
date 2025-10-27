using System;
using Craftgate.Common;
using Craftgate.Model;
using Newtonsoft.Json;

namespace Craftgate.Request
{
    public class CreateReportRequest
    {
        [JsonConverter(typeof(DateTimeConverterUsingDateTimeParse), "yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime StartDate { get; set; }
        [JsonConverter(typeof(DateTimeConverterUsingDateTimeParse), "yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime EndDate { get; set; }
        public ReportPeriod ReportPeriod { get; set; }
        public ReportType  ReportType { get; set; } 
    }
}