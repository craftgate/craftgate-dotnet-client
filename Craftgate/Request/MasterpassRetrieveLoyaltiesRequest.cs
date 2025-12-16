namespace Craftgate.Request
{
    public class MasterpassRetrieveLoyaltiesRequest
    {
        public string Msisdn { get; set; }
        public string BinNumber { get; set; }
        public string CardName { get; set; }
        public int? MasterpassIntegrationVersion { get; set; }
    }
}