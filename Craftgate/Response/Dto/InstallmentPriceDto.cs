namespace Craftgate.Response.Dto
{
    public class InstallmentPriceDto
    {
        public string PosAlias { get; set; }
        public int InstallmentNumber { get; set; }
        public decimal InstallmentPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}