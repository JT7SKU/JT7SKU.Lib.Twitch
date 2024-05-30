using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket_Messages
{
    internal class ReconnectMessage
    {
        public object MetaData { get; set; }
        public object Payload { get; set; }
    }
    public record ReconnectMessageMetadata
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
    }
    public record ReconnectMessagePayload
    {
        public object ReconnectMessageSession { get; set; }
    }
    public record ReconnectMessageSession
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public int KeepAliveTimeoutSeconds { get; set; }
        public string ReconnectUrl { get; set; }
        public DateTime ConnectedAt { get; set; }
    }
}
