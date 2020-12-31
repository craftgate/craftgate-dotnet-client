using System.Collections.Generic;

namespace Craftgate.Response.Common
{
    public class ListResponse<T>
    {
        public IList<T> Items { get; set; } = new List<T>();
        public int? Page { get; set; }
        public int? Size { get; set; }
        public long? TotalSize { get; set; }
    }
}