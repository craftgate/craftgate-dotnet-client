using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class SearchMerchantPosRequest
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public Currency? Currency { get; set; }
        public bool? EnableInstallment { get; set; }
        public bool? EnableForeignCard { get; set; }
        public string BankName { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}