using System;

namespace Craftgate.Response.Dto
{
    public class IVRCardTokenizationResponse
    {
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string SecureFieldsToken { get; set; }
    }
}