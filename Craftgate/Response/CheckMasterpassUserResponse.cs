namespace Craftgate.Response
{
    public class CheckMasterpassUserResponse
    {
        public bool? IsEligibleToUseMasterpass { get; set; }
        public bool? IsAnyCardSavedInCustomerProgram { get; set; }
        public bool? HasMasterpassAccount { get; set; }
        public bool? HashAnyCardSavedInMasterpassAccount { get; set; }
        public bool? IsMasterpassAccountLinkedWithMerchant { get; set; }
        public bool? IsMasterpassAccountLocked { get; set; }
        public bool? IsPhoneNumberUpdatedInAnotherMerchant { get; set; }
        public string AccountStatus { get; set; }
    }
}