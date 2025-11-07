using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum CardProvider
    {
        [EnumMember(Value = "IYZICO")] IYZICO,
        [EnumMember(Value = "IPARA")] IPARA,
        [EnumMember(Value = "BIRLESIK_ODEME")] BIRLESIK_ODEME,
        [EnumMember(Value = "MEX")] MEX
    }
}