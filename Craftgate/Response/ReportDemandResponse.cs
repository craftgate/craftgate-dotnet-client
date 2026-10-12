using System;

namespace Craftgate.Response
{
    public class ReportDemandResponse
    {
        public long Id { get; set; }
        public string ReportType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}