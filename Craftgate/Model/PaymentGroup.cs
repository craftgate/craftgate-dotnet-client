using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentGroup
    {
        [EnumMember(Value = "PRODUCT")] PRODUCT,

        [EnumMember(Value = "LISTING_OR_SUBSCRIPTION")]
        LISTING_OR_SUBSCRIPTION
    }
}