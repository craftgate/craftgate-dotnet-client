namespace Craftgate.Response.Dto
{
    public class InstallmentPriceDto
    {
        public string PosAlias { get; set; }
        public int InstallmentNumber { get; set; }
        public decimal InstallmentPrice { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal TotalPrice { get; set; }
        public string InstallmentLabel { get; set; }
        public bool LoyaltySupported { get; set; }
    }
}