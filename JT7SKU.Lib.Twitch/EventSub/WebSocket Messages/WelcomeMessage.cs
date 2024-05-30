using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket
{
    internal class WelcomeMessage
    {
        public WelcomeMessageMetaData MetaData { get; set; }
        public WelcomeMessagePayload Payload { get; set; }
    }
    public record WelcomeMessageMetaData
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
    }
    public record WelcomeMessagePayload
    {
        public WelcomeMessageSession Session { get; set; }
    }
    public record WelcomeMessageSession
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public int KeepAliveTimeoutSeconds { get; set; }
        public string ReconnectUrl { get; set; }
        public DateTime ConnectedAt { get; set; }
    }
}
