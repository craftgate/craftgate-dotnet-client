using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request.Dto
{
    public class TokenizedCard
    {
        public TokenizedCardType? Type { get; set; }
        public Dictionary<string, object> Data { get; set; }
    }
}