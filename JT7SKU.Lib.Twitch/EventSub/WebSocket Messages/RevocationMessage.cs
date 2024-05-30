using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket_Messages
{
    internal class RevocationMessage
    {
        public object MetaData { get; set; }
        public object Payload { get; set; }
    }
    public record RevocationMessageMetadata
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
    }
    public record RevocationMessagePayload
    {
        public Subscription Subscription { get; set; }
    }
}
