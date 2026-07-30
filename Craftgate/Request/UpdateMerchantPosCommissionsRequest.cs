using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request.Common;
using Craftgate.Request.Dto;

namespace Craftgate.Request
{
    public class UpdateMerchantPosCommissionsRequest : BaseRequest
    {
        public IList<UpdateMerchantPosCommission> Commissions { get; set; }
    }
}