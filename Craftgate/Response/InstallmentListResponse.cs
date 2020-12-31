using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class InstallmentListResponse
    {
        public IList<Installment> Items { get; set; }
    }
}