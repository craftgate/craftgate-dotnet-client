using Craftgate.Model;

namespace Craftgate.Request
{
    public class RetrieveDailyPaymentReportRequest
    {
        public string ReportDate { get; set; }
        public ReportFileType? FileType { get; set; }
    }
}