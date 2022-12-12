using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum WebhookStatus
    {
        [EnumMember(Value = "SUCCESS")] SUCCESS,
        [EnumMember(Value = "FAILURE")] FAILURE
    }
}