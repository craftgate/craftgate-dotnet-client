using Craftgate.Model;

namespace Craftgate.Request
{
    public class UpdateProductRequest
    {
        public Status Status { get; set; }
        public string Name {get; set;}
        public string Channel {get; set;}
        public decimal Price {get; set;}
        public Currency Currency {get; set;}
        public string Description {get; set;}
        public string EnabledInstallments {get; set;}
    }
}