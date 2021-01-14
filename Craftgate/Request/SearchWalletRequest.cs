using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchWalletRequest
    {
        public long? MemberId { set; get; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}