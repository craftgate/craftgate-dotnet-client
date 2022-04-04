namespace Craftgate.Response
{
    public class MemberResponse
    {
        public long? Id { get; set; }
        public string Status { get; set; }
        public bool IsBuyer { get; set; }
        public bool IsSubMerchant { get; set; }
        public string MemberType { get; set; }
        public string MemberExternalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string LegalCompanyTitle { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string Iban { get; set; }
        public string SettlementEarningsDestination { get; set; }
        public decimal WalletLowerLimit { get; set; }
    }
}