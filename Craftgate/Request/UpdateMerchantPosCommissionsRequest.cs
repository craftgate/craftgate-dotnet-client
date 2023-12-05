using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class UpdateMerchantPosCommissionsRequest
    {
        public IList<UpdateMerchantPosCommission> Commissions { get; set; }
    }
}