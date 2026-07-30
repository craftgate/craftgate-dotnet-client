using System;
using Craftgate.Model;
using Craftgate.Request.Common;

namespace Craftgate.Request
{
    public class SearchPayoutRowsRequest : BaseRequest
    {
        public FileStatus FileStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}