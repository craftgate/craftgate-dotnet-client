using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RetrieveDailyTransactionReportRequest : BaseRequest
    {
        public string ReportDate { get; set; }
        public ReportFileType? FileType { get; set; }
    }
}