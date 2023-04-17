using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchSettlementRowsRequest
    {
        public FileStatus? FileStatus { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}