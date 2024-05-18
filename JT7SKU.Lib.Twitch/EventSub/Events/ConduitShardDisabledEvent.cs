using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events
{
    public class ConduitShardDisabledEvent
    {
        public string ConduitId { get; set; }
        public string ShardId { get; set; }
        public string Status { get; set; }
        public Transport Transport { get; set; }
        public string Method { get; set; }
        public string Callback { get; set; }
        public string SessionId { get; set; }
        public string ConnectedAt { get; set; }
        public string DisconnectedAt { get; set; }
    }
}
