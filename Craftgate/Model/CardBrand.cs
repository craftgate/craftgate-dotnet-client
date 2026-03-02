using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardBrand
    {
        [EnumMember(Value = "Bonus")] BONUS,
        [EnumMember(Value = "Axess")] AXESS,
        [EnumMember(Value = "Maximum")] MAXIMUM,
        [EnumMember(Value = "World")] WORLD,
        [EnumMember(Value = "Paraf")] PARAF,
        [EnumMember(Value = "CardFinans")] CARD_FINANS,
        [EnumMember(Value = "Bankkart Combo")] BANKKART_COMBO,
        [EnumMember(Value = "Advantage")] ADVANTAGE,
        [EnumMember(Value = "Sağlam Kart")] SAGLAM_KART
    }
}