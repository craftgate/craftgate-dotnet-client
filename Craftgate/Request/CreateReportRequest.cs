using System;
using Craftgate.Common;
using Craftgate.Model;
using Craftgate.Request.Common;
using Newtonsoft.Json;

namespace Craftgate.Request
{
    public class CreateReportRequest : BaseRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReportPeriod ReportPeriod { get; set; }
        public ReportType  ReportType { get; set; } 
    }
}