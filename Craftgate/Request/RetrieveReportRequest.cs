using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class RetrieveReportRequest : BaseRequest
    {
        public ReportFileType FileType { get; set; }
    }
}