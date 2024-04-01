using System;
using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateMemberRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public MemberType? MemberType { get; set; }
        public string LegalCompanyTitle { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string Iban { get; set; }
        public SettlementEarningsDestination? SettlementEarningsDestination { get; set; }

        [Obsolete("deprecated since version 1.0.45. use CreateWalletRequest.NegativeAmountLimit instead.")]
        public decimal? NegativeWalletAmountLimit { get; set; }

        public decimal? SubMerchantMaximumAllowedNegativeBalance { get; set; }
        public bool? IsBuyer { get; set; }
        public bool? IsSubMerchant { get; set; }
    }
}