using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentGroup
    {
        [EnumMember(Value = "PRODUCT")] Product,

        [EnumMember(Value = "LISTING_OR_SUBSCRIPTION")]
        ListingOrSubscription
    }
}