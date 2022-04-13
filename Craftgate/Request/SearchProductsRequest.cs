using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchProductsRequest
    {
        public string Name {get; set;}
        public decimal? MinPrice {get; set;}
        public decimal? MaxPrice {get; set;}
        public Currency? Currency {get; set;}
        public string Channel {get; set;}

        public int? Page { get; set; } = 0;
        public int? Size { get; set; } = 25;
    }
}