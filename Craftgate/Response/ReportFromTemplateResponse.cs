using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Response
{
    public class ReportFromTemplateResponse
    {
        public long Id { get; set; }
        public ReportState ReportState { get; set; }
        public List<ReportFilter> Filters { get; set; }
        public List<string> Columns { get; set; }
        public long ReportSchemaId { get; set; }
    }
}
