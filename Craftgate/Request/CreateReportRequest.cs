using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateReportRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReportPeriod ReportPeriod { get; set; }
        public ReportType  ReportType { get; set; } 
    }
}