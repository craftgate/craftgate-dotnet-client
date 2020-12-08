namespace Craftgate.Response.Dto
{
    public class InstallmentPriceDto
    {
        public int InstallmentNumber { get; set; }
        public decimal InstallmentPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}