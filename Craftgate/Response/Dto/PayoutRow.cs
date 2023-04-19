using System;
using Craftgate.Model;

namespace Craftgate.Response.Dto
{
    public class PayoutRow
    {
        public string Name {get; set;}
        public string Iban {get; set;}
        public long PayoutId {get; set;}
        public long MerchantId {get; set;}
        public string MerchantType {get; set;}
        public decimal PayoutAmount {get; set;}
        public DateTime PayoutDate {get; set;}
    }
}