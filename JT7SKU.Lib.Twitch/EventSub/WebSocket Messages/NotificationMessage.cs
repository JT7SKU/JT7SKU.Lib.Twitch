using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket_Messages
{
    internal class NotificationMessage
    {
        public object MetaData { get; set; }
        public object Payload { get; set; }
        public Event Event { get; set; }
    }
    public record NotificationMessageMetadata
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
        public string SubscriptionType { get; set; }
        public string SubscriptionVersion { get; set; }
    }
    public record NotificationMessagePayload
    {
        public object Subscription { get; set; }
    }
    public record NotificationMessageSubscription
    {
        public string Id { get; set; }
        public SubscriptionStatus Status { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public int Cost { get; set; }
        public Condition Condition { get; set; }
        public Transport Transport { get; set; }
    }
}
