using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum BnplCartItemType
    {
        [EnumMember(Value = "MOBILE_PHONE_PRICE_ABOVE_REGULATION_LIMIT")]
        MOBILE_PHONE_PRICE_ABOVE_REGULATION_LIMIT,

        [EnumMember(Value = "MOBILE_PHONE_PRICE_BELOW_REGULATION_LIMIT")]
        MOBILE_PHONE_PRICE_BELOW_REGULATION_LIMIT,
        [EnumMember(Value = "TABLET")] TABLET,
        [EnumMember(Value = "COMPUTER")] COMPUTER,
        [EnumMember(Value = "TABLET_WITH_CAMPAIGN")] TABLET_WITH_CAMPAIGN,

        [EnumMember(Value = "CONSTRUCTION_MARKET")]
        CONSTRUCTION_MARKET,
        [EnumMember(Value = "GOLD")] GOLD,

        [EnumMember(Value = "DIGITAL_PRODUCTS")]
        DIGITAL_PRODUCTS,
        [EnumMember(Value = "SUPERMARKET")] SUPERMARKET,
        [EnumMember(Value = "WHITE_GOODS")] WHITE_GOODS,

        [EnumMember(Value = "WEARABLE_TECHNOLOGY")]
        WEARABLE_TECHNOLOGY,

        [EnumMember(Value = "SMALL_HOME_APPLIANCES")]
        SMALL_HOME_APPLIANCES,
        [EnumMember(Value = "TV")] TV,
        [EnumMember(Value = "GAMES_CONSOLES")] GAMES_CONSOLES,

        [EnumMember(Value = "AIR_CONDITIONER_AND_HEATER")]
        AIR_CONDITIONER_AND_HEATER,
        [EnumMember(Value = "ELECTRONICS")] ELECTRONICS,
        [EnumMember(Value = "ACCESSORIES")] ACCESSORIES,

        [EnumMember(Value = "MOM_AND_BABY_AND_KIDS")]
        MOM_AND_BABY_AND_KIDS,
        [EnumMember(Value = "SHOES")] SHOES,
        [EnumMember(Value = "CLOTHING")] CLOTHING,

        [EnumMember(Value = "COSMETICS_AND_PERSONAL_CARE")]
        COSMETICS_AND_PERSONAL_CARE,
        [EnumMember(Value = "FURNITURE")] FURNITURE,
        [EnumMember(Value = "HOME_LIVING")] HOME_LIVING,

        [EnumMember(Value = "AUTOMOBILE_MOTORCYCLE")]
        AUTOMOBILE_MOTORCYCLE,
        [EnumMember(Value = "MOBILE_PHONE_REFURBISHED")]
        MOBILE_PHONE_REFURBISHED,
        [EnumMember(Value = "OTHER")] OTHER
    }
}