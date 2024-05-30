using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket_Messages
{
    internal class KeepAliveMessage
    {
        public object MetaData { get; set; }
        public object Payload { get; set; }
    }
    public record KeepaliveMessageMetadata
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
    }
   
}
