using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchMembersRequest
    {
        public bool? IsBuyer { get; set; }
        public bool? IsSubMerchant { get; set; }
        public string Name { get; set; }
        public ISet<long> MemberIds { get; set; }
        public MemberType? MemberType { get; set; }
        public string MemberExternalId { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}