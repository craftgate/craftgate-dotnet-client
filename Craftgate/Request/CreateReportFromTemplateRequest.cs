using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Common;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class CreateReportFromTemplateRequest : BaseRequest
    {
        public List<ReportFilter> Filters { get; set; }
        public ISet<ReportFileType> FileFormats { get; set; }
    }
}
