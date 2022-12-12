using Craftgate.Request.Common;
using Craftgate.Request.Dto;

namespace Craftgate.Adapter
{
    public class HookAdapter : BaseAdapter
    {
        public HookAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }
        
        public bool IsWebhookVerified(string merchantHookKey, string incomingSignature, WebhookData webhookData)
        {
            if (merchantHookKey == null || incomingSignature == null || webhookData == null)
            {
                return false;
            }

            string data = webhookData.EventType.ToString() + webhookData.EventTimestamp.ToString() +
                          webhookData.Status.ToString() + webhookData.PayloadId.ToString();
            string signature = HashGenerator.GenerateWebhookSignature(merchantHookKey, data);
            return signature == incomingSignature;
        }
    }
}