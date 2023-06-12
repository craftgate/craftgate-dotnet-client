using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum AdditionalAction
    {
        [EnumMember(Value = "CONTINUE_IN_CLIENT")] CONTINUE_IN_CLIENT,
        [EnumMember(Value = "SHOW_HTML_CONTENT")] SHOW_HTML_CONTENT,
        [EnumMember(Value = "NONE")] NONE
    }
}