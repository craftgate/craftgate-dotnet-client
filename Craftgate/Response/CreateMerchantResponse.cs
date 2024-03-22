using System;
using System.Collections.Generic;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class CreateMerchantResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<MerchantApiCredential> MerchantApiCredentials { get; set; }
    }
}