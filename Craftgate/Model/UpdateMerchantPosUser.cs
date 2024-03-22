namespace Craftgate.Model
{
    public class UpdateMerchantPosUser
    {
        public long Id { get; set; }
        public string PosUsername { get; set; }
        public string PosPassword { get; set; }
        public PosUserType PosUserType { get; set; }
        public PosOperationType PosOperationType { get; set; }
    }
}