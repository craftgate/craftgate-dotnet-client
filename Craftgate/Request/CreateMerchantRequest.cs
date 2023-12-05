using System.Collections.Generic;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class CreateMerchantRequest
    {
        public string Name { get; set; }
        public string LegalCompanyTitle { get; set; }
        public string Email { get; set; }
        public string SecretWord { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}