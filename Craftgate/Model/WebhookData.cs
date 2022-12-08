using System;
using Craftgate.Model;

namespace Craftgate.Request.Dto
{
    public class WebhookData
    {
        public WebhookEventType EventType { get; set; }
        public DateTime EventTime { get; set; }
        public long EventTimestamp { get; set; }
        public WebhookStatus Status { get; set; }
        public string PayloadId { get; set; }
    }
}