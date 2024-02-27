using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelRaidEvent
    {
        public string FromBroadcasterUserId { get; set; }
        public string FromBroadcasterLogin { get; set; }
        public string FromBroadcasterUserName { get; set; }
        public string ToBroadcasterUserId { get; set;}
        public string ToBroadcasterLogin { get; set;}
        public string ToBroadcasterUserName { get; set;}
        public int Viewers { get; set; }
    }
}
