using System;
using System.Collections.Generic;
using System.Text;
using Craftgate.Model;
using Craftgate.Response.Dto;

namespace Craftgate.Response
{
    public class BnplLimitInquiryResponse
    {
        public PaymentStatus PaymentStatus { get; set; }
        public ApmAdditionalAction AdditionalAction { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}