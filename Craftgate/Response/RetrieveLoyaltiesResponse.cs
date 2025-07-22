using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class RetrieveLoyaltiesResponse
    {
        public string CardBrand { get; set; }
        public string CardIssuerBankName;
        public long CardIssuerBankId;
        public bool Force3ds { get; set; }
        public MerchantPos Pos { get; set; }
        public IList<Loyalty> Loyalties { get; set; }
    }
}